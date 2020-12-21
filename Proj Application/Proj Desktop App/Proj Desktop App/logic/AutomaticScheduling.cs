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
        private List<Availability> availableEmployees;
        /// <summary>
        /// 15 slot array, slot 0 is monday morning, slot 5 is tuesday afternoon and so on
        /// </summary>
        private List<Employee>[] assignedEmployees;
        
        /// <summary>
        /// The department the algorithm will be running for
        /// </summary>
        private Departments managerDepartment;
        /// <summary>
        /// Contains all problems the algorithm encountered
        /// </summary>
        private List<string> reports;

        public AutomaticScheduling(Departments managerDepartment, ScheduleStorage schStorage)
        {
            assignedEmployees = new List<Employee>[15];
            availableEmployees = schStorage.GetAvailabilitiesByDepartment(managerDepartment);
            this.managerDepartment = managerDepartment;
        }

        public bool DoTheSchedule()
        {
            InitializeAssignmentArray();
            availableEmployees.Sort();
            foreach(Availability availability in this.availableEmployees)
            {
                while(availability.leeway > 0)
                {
                    int mostCrowdedShift = -1;
                    int assignedEmployeeCount = -1;
                    for(int i = 0; i < 14; i++)
                    {
                        if (this.assignedEmployees[i].Contains(availability.employee))
                        {
                            if(this.assignedEmployees[i].Count > assignedEmployeeCount)
                            {
                                assignedEmployeeCount = this.assignedEmployees[i].Count;
                                mostCrowdedShift = i;
                            }
                        }
                    }
                    if(assignedEmployeeCount > 5 && (availability.employee.GetActiveContract().Position == PositionType.Depot_Worker || availability.employee.GetActiveContract().Position == PositionType.Sales_Worker))
                    {
                        this.assignedEmployees[mostCrowdedShift].Remove(availability.employee);
                        availability.leeway = availability.leeway - 1;
                    }
                    else if(assignedEmployeeCount > 3 && (availability.employee.GetActiveContract().Position == PositionType.Depot_Worker || availability.employee.GetActiveContract().Position == PositionType.Sales_Worker))
                    {
                        this.assignedEmployees[mostCrowdedShift].Remove(availability.employee);
                        availability.leeway = availability.leeway - 1;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Add all availabilities to assigned shifts
        /// </summary>
        private void InitializeAssignmentArray()
        {
            //The main goal here is to treat each availability as an assigned shift
            //These are then iterated through until employees no longer work extra shifts
            foreach(Availability availability in availableEmployees) //iterate through employees with submitted availabilities
            {
                for(int i = 0; i < 5; i++) //Iterate through weekdays
                {
                    switch (availability.WeekAvailability[i]) //Determine what employee has submitted for this week day
                    {
                        //assign employee's submitted shift to 
                        //by adding i to the shift type (morning 0 afternoon 1 evening 2) 
                        //we can access any specific shift of the week in a loop
                        //For example i = 4 refers to tuesday afternoon and i = 0 monday morning
                        case ShiftType.Morning:
                            assignedEmployees[0 + i].Add(availability.employee);
                            break;
                        case ShiftType.Afternoon:
                            assignedEmployees[1 + i].Add(availability.employee);
                            break;
                        case ShiftType.Evening:
                            assignedEmployees[2 + i].Add(availability.employee);
                            break;
                        case ShiftType.Morning_Afternoon:
                            assignedEmployees[0 + i].Add(availability.employee);
                            assignedEmployees[1 + i].Add(availability.employee);
                            break;
                        case ShiftType.Afternoon_Evening:
                            assignedEmployees[1 + i].Add(availability.employee);
                            assignedEmployees[2 + i].Add(availability.employee);
                            break;
                        case ShiftType.Morning_Evening:
                            assignedEmployees[0 + i].Add(availability.employee);
                            assignedEmployees[2 + i].Add(availability.employee);
                            break;
                        case ShiftType.FullDay:
                            assignedEmployees[0 + i].Add(availability.employee);
                            assignedEmployees[1 + i].Add(availability.employee);
                            assignedEmployees[2 + i].Add(availability.employee);
                            break;
                    }
                }
            }
        }
    }
}
