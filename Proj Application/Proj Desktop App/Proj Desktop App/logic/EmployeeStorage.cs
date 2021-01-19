using Proj_Desktop_App.dataAccess;
using System;
using System.Collections.Generic;

namespace Proj_Desktop_App
{
    public class EmployeeStorage
    {
        private List<Employee> employees;

        EmployeeManagement emplMan;

        public EmployeeStorage(DepartmentStorage departments)
        {
            this.employees = new List<Employee>();

            // Load all employees from DB
            emplMan = new EmployeeManagement(departments);
            Employee[] employees = emplMan.GetAllEmployees();
            if (employees != null)
            {
                this.employees.AddRange(employees);
            }
        }

        /// <summary>
        /// Add a new employee
        /// </summary>
        public void AddEmployee(int BSN, string firstName, string lastName, char gender, DateTime birthDate,
            string languages, string certificates, string phoneNumber, string address, string contactEmail,
            DateTime startDate, DateTime endDate, PositionType position, Department department, decimal fte)
        {
            // Check for unique BSN
            if (GetEmployee(BSN) == null)
            {
                // Initialize employee
                Employee employee = new Employee(BSN, firstName, lastName, gender, birthDate,
                    languages, certificates, phoneNumber, address, contactEmail);

                // Add first contract
                ContractManagement contrMan = new ContractManagement();
                Contract contract = new Contract(-1, startDate, endDate, 1,
                    department, position, contrMan.GetStartingSalary(position), fte);
                employee.AddFirstContract(contract);

                // Add employee and contarct to database
                if (emplMan.AddEmployee(employee))
                {
                    // Initialize auto incremented contract Id
                    int id = contrMan.GetLatestContractId(BSN);
                    if (id != -1)
                    {
                        contract.Id = id;
                        // Add employee locally
                        employees.Add(employee);
                    }
                    else
                    {
                        throw new Exception("Failed to add contract");
                    }
                }
                else
                {
                    throw new Exception("Failed to add employee");
                }
            }
            else
            {
                throw new Exception("An employee with this BSN already exists");
            }
        }

        /// <summary>
        /// Get an employee based on their BSN
        /// </summary>
        public Employee GetEmployee(int bsn)
        {
            foreach (Employee employee in employees)
            {
                if (bsn == employee.GetBSN())
                {
                    return employee;
                }
            }
            return null;
        }

        /// <summary>
        /// Get all / only employed employees
        /// </summary>
        public Employee[] GetEmployees(bool onlyEmployed)
        {
            if (onlyEmployed)
            {
                List<Employee> employees = new List<Employee>();
                foreach (Employee empl in this.employees)
                {
                    if (empl.IsEmployed() == onlyEmployed)
                    {
                        employees.Add(empl);
                    }
                }
                return employees.ToArray();
            }
            else
            {
                return this.employees.ToArray();
            }
        }

        /// <summary>
        /// Get employees by partial bsn
        /// </summary>
        public Employee[] GetEmployees(bool onlyEmployed, int bsn)
        {
            List<Employee> employees = new List<Employee>();
            foreach (Employee empl in GetEmployees(onlyEmployed))
            {
                if (empl.GetBSN().ToString().Contains(bsn.ToString()))
                {
                    employees.Add(empl);
                }
            }
            return employees.ToArray();
        }

        /// <summary>
        /// Get employees by partial name
        /// </summary>
        public Employee[] GetEmployees(bool onlyEmployed, string name)
        {
            List<Employee> employees = new List<Employee>();
            foreach (Employee empl in GetEmployees(onlyEmployed))
            {
                string fullName = $"{empl.firstName} {empl.lastName}".ToLower(); ;
                if ((fullName).Contains(name.ToLower()))
                {
                    employees.Add(empl);
                }
            }
            return employees.ToArray();
        }

        /// <summary>
        /// Get employees by department
        /// </summary>
        public Employee[] GetEmployees(Department department)
        {
            List<Employee> temp = new List<Employee>();
            foreach (Employee e in GetEmployees(true))
            {
                if (e.IsEmployed() == true && e.GetDepartment().Id == department.Id)
                {
                    temp.Add(e);
                }
            }
            return temp.ToArray();
        }
    }
}

