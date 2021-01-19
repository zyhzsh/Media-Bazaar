using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    public class AutomaticScheduling
    {

        //Find some way to implement scheduleStorage here
        //will need merge

        /// <summary>
        /// Contains all submitted availability in order of leeway ascending
        /// </summary>
        private List<Availability> availableWorkers;
        private List<Availability> availableManagers;
        /// <summary>
        /// 15 slot array, slot 0 is monday morning, slot 5 is tuesday afternoon and so on
        /// </summary>
        private List<Employee>[] assignedEmployees;
        
        
        /// <summary>
        /// Contains all problems the algorithm encountered
        /// </summary>
        private List<string> overtimeReports;
        private string managerStaff;
        private string workerStaff;

        public AutomaticScheduling(Department managerDepartment, ScheduleStorage schStorage)
        {
            assignedEmployees = new List<Employee>[15];
            for(int i = 0; i < 15; i++)
            {
                assignedEmployees[i] = new List<Employee>();
            }
            overtimeReports = new List<string>();

            availableWorkers = schStorage.GetWorkerAvailabilitiesByDepartment(managerDepartment);
            availableManagers = schStorage.GetManagerAvailabilitiesByDepartment(managerDepartment);
        }

        /// <summary>
        /// Runs the algorithm and returns workers
        /// </summary>
        /// <returns></returns>
        public List<Employee>[] AssignWorkers()
        {
            overtimeReports = new List<string>();
            List<Employee>[] workers = AssignAvailabilities(availableWorkers);
            CheckOverstaffing();
            return workers;
        }

        /// <summary>
        /// Runs the algorithm and returns managers
        /// </summary>
        /// <returns></returns>
        public List<Employee>[] AssignManagers()
        {
            overtimeReports = new List<string>();
            List<Employee>[] managers = AssignAvailabilities(availableManagers);
            CheckOverstaffing();
            return managers;
        }


        private List<Employee>[] AssignAvailabilities(List<Availability> availabilities)
        {
            ClearAssignmentArray();
            InitializeAssignmentArray(availabilities);
            availabilities.Sort();
            foreach(Availability availability in availabilities)
            {
                //The algorithm will iterate through each employee in order of descending flexibility
                //Employees here are represented as an Availability object for convenience
                //Flexibility is represented by the leeway variable in Availability objects
                int x = 5;
                //Then the algorithm will begin removing the employee from the most crowded shift of the week
                //until the number of shifts they are assigned to matches their FTE

                //This can result in the store closing so reports of such situations are gathered to be displayed at the end
                while(availability.leeway > 0)
                {
                    bool tripleShiftDay = false;
                    int mostCrowdedShift = -1;
                    int assignedEmployeeCount = -1;

                    //This employee is flexible,
                    //the algorithm will first check if that is because they are available for an entire weekday
                    for (int i = 0; i <= 12; i += 3)
                    {
                        //Here the algorithm iterates through each weekday checking if the employee has submitted the entire day as availability
                        //Note that it iterates through shifts in leaps of 3 as each day has 3 shifts

                        if (this.assignedEmployees[i].Contains(availability.employee) && this.assignedEmployees[i + 1].Contains(availability.employee) && this.assignedEmployees[i + 2].Contains(availability.employee))
                        {
                            //This employee is assigned to an entire day, one of these three shifts must be unassigned
                            //This takes priority above regular crowded shifts
                            tripleShiftDay = true;
                            for (int j = i; j < i + 3; j++)
                            {
                                if (assignedEmployeeCount < assignedEmployees[j].Count)
                                {
                                    mostCrowdedShift = j;
                                    assignedEmployeeCount = assignedEmployees[j].Count;
                                }
                            }
                            break;
                            //Here the most crowded shift of the day has been found
                            //The employee will be unassigned from it below
                        }
                    }
                    if (!tripleShiftDay)
                    {
                        //In this situation the employee has not submitted availability for an entire day
                        //The algorithm then prioritizes removing the most crowded shift in the week as normal
                        for (int i = 0; i < 14; i++)
                        {
                            if (this.assignedEmployees[i].Contains(availability.employee))
                            {
                                if (this.assignedEmployees[i].Count > assignedEmployeeCount)
                                {
                                    assignedEmployeeCount = this.assignedEmployees[i].Count;
                                    mostCrowdedShift = i;
                                }
                            }
                        }
                    }
                    
                    
                    if(assignedEmployeeCount > 1 && (availability.employee.GetPosition() == PositionType.Depot_Manager || availability.employee.GetPosition() == PositionType.Sales_Manager))
                    {
                        //More than one manager in this shift, don't assign employee, no issue
                        this.assignedEmployees[mostCrowdedShift].Remove(availability.employee);
                        availability.leeway--;
                    }
                    else if(assignedEmployeeCount > 3 && (availability.employee.GetPosition() == PositionType.Depot_Worker || availability.employee.GetPosition() == PositionType.Sales_Worker))
                    {
                        //More than 3 workers in this shift, don't assign employee, no issue
                        this.assignedEmployees[mostCrowdedShift].Remove(availability.employee);
                        availability.leeway--;
                    }
                    else if (tripleShiftDay)
                    {
                        //Removing the employee would result in too few workers/managers but they can't work the entire day
                        //Previously this created a report but the client said the information was not needed since a manager
                        //can't do anything with it, so now it functions identically to above situations
                        
                        this.assignedEmployees[mostCrowdedShift].Remove(availability.employee);
                        availability.leeway--;
                    }
                    else
                    {
                        if((assignedEmployeeCount == 3 && (availability.employee.GetPosition() == PositionType.Depot_Worker || availability.employee.GetPosition() == PositionType.Sales_Worker)) || (assignedEmployeeCount == 1 && (availability.employee.GetPosition() == PositionType.Depot_Manager || availability.employee.GetPosition() == PositionType.Sales_Manager)))
                        {
                            overtimeReports.Add(availability.employee + " could work overtime on " + ShiftIndexToString(mostCrowdedShift) + " to keep the store open.");
                        }

                        // In this situation removing the employee from even the most crowded shift
                        // would cause the store to close due to too few employees/managers

                        // The algorithm is met with a dilema: keep the store open by assigning the employee extra shifts
                        // or close the store to prevent overworking. 
                        // This would in turn have an impact on other employees pay, as this shift would no longer function

                        // For now the algorithm simply keeps the employee and notes the problem down
                        // At the end the algorithm lists every problem it came across
                        // The manager would have to unassign the employee if they don't wish to work overtime

                        this.assignedEmployees[mostCrowdedShift].Remove(availability.employee);
                        availability.leeway--;
                    }
                }
            }
            List<Employee>[] resultEmployees = new List<Employee>[15];
            for(int i = 0; i <15; i++)
            {
                resultEmployees[i] = new List<Employee>();
                resultEmployees[i].AddRange(assignedEmployees[i]);
            }
            return resultEmployees;
        }

        /// <summary>
        /// Fill assigned employees with availabilities
        /// </summary>
        /// <param name="availabilities"></param>
        private void InitializeAssignmentArray(List<Availability> availabilities)
        {
            availabilities.Sort();
            //The main goal here is to treat each availability as an assigned shift
            //These are then iterated through until employees no longer work extra shifts
            //This is done separately for workers and managers
            foreach(Availability availability in availabilities) //iterate through employees with submitted availabilities
            {
                for(int i = 0; i < 5; i++) //Iterate through weekdays
                {
                    switch (availability.WeekAvailability[i]) //Determine what employee has submitted for this week day
                    {
                        //Here the employee's availability is converted into assignedshifts
                        //by adding i*3 to the shift type (morning 0 afternoon 1 evening 2) 
                        //we can access any specific shift of the week in a loop
                        //For example (2 + 2*3) = 8 which refers to Wednesday evening and i = 0 monday morning
                        case ShiftType.Morning:
                            assignedEmployees[0 + i*3].Add(availability.employee);
                            break;
                        case ShiftType.Afternoon:
                            assignedEmployees[1 + i*3].Add(availability.employee);
                            break;
                        case ShiftType.Evening:
                            assignedEmployees[2 + i*3].Add(availability.employee);
                            break;
                        case ShiftType.Morning_Afternoon:
                            assignedEmployees[0 + i*3].Add(availability.employee);
                            assignedEmployees[1 + i*3].Add(availability.employee);
                            break;
                        case ShiftType.Afternoon_Evening:
                            assignedEmployees[1 + i*3].Add(availability.employee);
                            assignedEmployees[2 + i*3].Add(availability.employee);
                            break;
                        case ShiftType.Morning_Evening:
                            assignedEmployees[0 + i*3].Add(availability.employee);
                            assignedEmployees[2 + i*3].Add(availability.employee);
                            break;
                        case ShiftType.FullDay:
                            assignedEmployees[0 + i*3].Add(availability.employee);
                            assignedEmployees[1 + i*3].Add(availability.employee);
                            assignedEmployees[2 + i*3].Add(availability.employee);
                            break;
                        case ShiftType.None:
                            break;
                        default:
                            throw new ArgumentException("invalid shift type");
                    }
                }
            }
        }

        private void ClearAssignmentArray()
        {
            for(int i = 0; i < 15; i++)
            {
                this.assignedEmployees[i].Clear();
            }
        }
        public string[] GetOvertimeReports()
        {
            return this.overtimeReports.ToArray();
        }

        public string GetManagerReport()
        {
            return this.managerStaff;
        }

        public string GetWorkerReport()
        {
            return this.workerStaff;
        }

        private void CheckOverstaffing()
        {
            bool manager = false;
            bool overstaffed = false;
            bool understaffed = false;
            for(int i = 0; i < 15; i++)
            {
                if(assignedEmployees[i].Count > 0)
                {
                    if (assignedEmployees[i][0].GetPosition() == PositionType.Depot_Manager || assignedEmployees[i][0].GetPosition() == PositionType.Sales_Manager)
                    {
                        manager = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < 15; i++)
            {
                if(assignedEmployees[i].Count > 1 && manager || assignedEmployees[i].Count > 5 && !manager)
                {
                    overstaffed = true;
                }
                else if(assignedEmployees[i].Count < 1 && manager || assignedEmployees[i].Count < 3 && !manager)
                {
                    understaffed = true;
                }
                if (understaffed && overstaffed) break;
            }

            if(overstaffed && understaffed)
            {
                if (manager)
                    managerStaff = "Try to move managers around.";
                else
                    workerStaff = "Try to move workers around.";
            }
            else if(overstaffed && !understaffed)
            {
                if (manager)
                    managerStaff = ("Too many managers");
                else
                    workerStaff = ("Too many workers");
            }
            else if(!overstaffed && understaffed)
            {
                if (manager)
                    managerStaff = ("Not enough managers");
                else
                    workerStaff = ("Not enough workers");
            }
            else if(!overstaffed && !understaffed)
            {
                if (manager)
                    managerStaff = "You have enough managers";
                else
                    workerStaff = "You have enough workers";
            }
        }
        private string ShiftIndexToString(int i)
        {
            switch (i)
            {
                case 0:
                    return "Monday morning";
                case 1:
                    return "Monday afternoon";
                case 2:
                    return "Monday evening";
                case 3:
                    return "Tuesday morning";
                case 4:
                    return "Tuesday afternoon";
                case 5:
                    return "Tuesday evening";
                case 6:
                    return "Wednesday morning";
                case 7:
                    return "Wednesday afternoon";
                case 8:
                    return "Wednesday evening";
                case 9:
                    return "Thursday morning";
                case 10:
                    return "Thursday afternoon";
                case 11:
                    return "Thursday evening";
                case 12:
                    return "Friday morning";
                case 13:
                    return "Friday afternoon";
                case 14:
                    return "Friday evening";
                default:
                    return "Invalid weekday";
            }
        }
    }
}
