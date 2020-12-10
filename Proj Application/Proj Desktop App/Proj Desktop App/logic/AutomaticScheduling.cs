using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    public class AutomaticScheduling
    {
        private List<Availability> availableEmployees;

        private List<Employee>[] assignedEmployees;
        private Departments managerDepartment;
        private List<string> reports;

        public AutomaticScheduling()
        {
            assignedEmployees = new List<Employee>[15];
        }

        //public bool DoTheSchedule()
        //{

        //}
    }
}
