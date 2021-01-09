using Proj_Desktop_App.dataAccess;
using System;
using System.Collections.Generic;

namespace Proj_Desktop_App
{
    public class DepartmentStorage
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

        public bool AddDepartment(string name, bool sellsProducts)
        {
            Department department = new Department(name, sellsProducts);

            if (departmentMan.AddDepartment(department))
            {

                this.departments.Add(department);

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateDepartment(int id, string newName, bool sellsProducts)
        {
            if (departmentMan.UpdateDepartment(id, newName, sellsProducts))
            {
                GetDepartment(id).ChangeInfo(newName, sellsProducts);

                return true;
            }
            else 
            {
                return false;
            }
        }

        public bool RemoveDepartment(int id)
        {
            if (departmentMan.RemoveDepartment(GetDepartment(id)))
            {
                departments.Remove(GetDepartment(id));
                return true;
            }
            else
            {
                return false;
            }
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
