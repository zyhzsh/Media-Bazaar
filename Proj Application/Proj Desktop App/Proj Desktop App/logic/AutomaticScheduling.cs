using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    public class AutomaticScheduling
    {
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

        public AutomaticScheduling(Departments managerDepartment)
        {
            assignedEmployees = new List<Employee>[15];
            this.managerDepartment = managerDepartment;
        }

        public bool DoTheSchedule()
        {
            InitializeAssignmentArray();
            availableEmployees.Sort();
            return false;
        }
        private void InitializeAssignmentArray()
        {
            foreach(Availability availability in availableEmployees) //iterate through employees with submitted availabilities
            {
                for(int i = 0; i < 5; i++) //Iterate through weekdats
                {
                    switch (availability.WeekAvailability[i]) //Determine what employee has submitted for this week day
                    {
                        //assign employee's submitted shift to 
                        //by adding i to the shift type (morning 0 ... evening 2) 
                        //we can access any specific shift of the week in a loop
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
