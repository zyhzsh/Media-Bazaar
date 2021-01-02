using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj_Desktop_App.dataAccess;

namespace Proj_Desktop_App
{
    class DepartmentStorage
    {
        private List<Department> departments;

        // DB access class
        private DepartmentManagement departmentMan;

        public DepartmentStorage()
        {
            this.departments = new List<Department>();

            // Load departments form DB
            departmentMan = new DepartmentManagement();
            Department[] departments = departmentMan.GetDepartments();
            if (departments != null)
            {
                this.departments.AddRange(departments);
            }
        }

        public void AddDepartment()
        {
            throw new NotImplementedException();
        }

        public Department GetDepartment(int id)
        {
            foreach (Department department in departments)
            {
                if (department.Id == id)
                {
                    return department;
                }
            }
            return null;
        }

        public Department[] GetDepartments()
        {
            return this.departments.ToArray();
        }

        public Department[] GetSellingDepartments()
        {
            List<Department> departments = new List<Department>();
            foreach (Department department in this.departments)
            {
                if (department.SellsProducts)
                {
                    departments.Add(department);
                }
            }
            return departments.ToArray();
        }
    }
}
