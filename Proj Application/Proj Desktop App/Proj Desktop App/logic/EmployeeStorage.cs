using Proj_Desktop_App.dataAccess;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                employee.AddContract(contract);

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
            foreach(Employee e in GetEmployees(true))
            {
                if (e.IsEmployed() == true && e.GetDepartment().Id == department.Id)
                {
                    temp.Add(e);
                }
            }
            return temp.ToArray();
        }

        /// <summary>
        /// Leftover class for testing purposes
        /// </summary>
        private void AddEmployeeMockData()
        {
            //string format = "dd/MM/yyyy";
            //var cultureInf = CultureInfo.InvariantCulture;
            //AddEmployee(5467, "George", "Wood", 'M', DateTime.ParseExact("18/09/1997", format, cultureInf),"", "", "0031677777", "Eindhoven", "g.wood@gmail.com", DateTime.ParseExact("11/11/2020", format, cultureInf), DateTime.ParseExact("11/05/2021", format, cultureInf), PositionType.Administrator, Departments.office, 1);
            //AddEmployee(7890, "Nicole", "Green", 'F', DateTime.ParseExact("18/09/1997", format, cultureInf), "", "", "0031674628", "Eindhoven", "g.wood@gmail.com", DateTime.ParseExact("11/11/2020", format, cultureInf), DateTime.ParseExact("11/05/2021", format, cultureInf), PositionType.Sales_Worker, Departments.floorTwo, 0.5m);
            //AddEmployee(3992616, "Shenghang", "Zhu", 'M', DateTime.ParseExact("18/09/1997", format, cultureInf), "", "", "3992616", "Eindhoven", "g.wood@gmail.com", DateTime.ParseExact("11/11/2020", format, cultureInf), DateTime.ParseExact("11/05/2021", format, cultureInf), PositionType.Sales_Manager, Departments.floorFour, 1);
            //AddEmployee(3376540, "David", "van Rijthoven", 'M', DateTime.ParseExact("18/09/1997", format, cultureInf), "", "", "3376540", "Eindhoven", "g.wood@gmail.com", DateTime.ParseExact("11/11/2020", format, cultureInf), DateTime.ParseExact("11/05/2021", format, cultureInf), PositionType.Depot_Manager, Departments.warehouse, 1);
            //AddEmployee(4090918, "Martin", "Dzhurov", 'M', DateTime.ParseExact("18/09/1997", format, cultureInf), "", "", "4090918", "Eindhoven", "g.wood@gmail.com", DateTime.ParseExact("11/11/2020", format, cultureInf), DateTime.ParseExact("11/05/2021", format, cultureInf), PositionType.Administrator, Departments.office, 1);
            //AddEmployee(443892, "Mohammed", "Al-Eryani", 'M', DateTime.ParseExact("18/09/1997", format, cultureInf), "", "", "443892", "Eindhoven", "g.wood@gmail.com", DateTime.ParseExact("11/11/2020", format, cultureInf), DateTime.ParseExact("11/05/2021", format, cultureInf), PositionType.Sales_Manager, Departments.floorOne, 1);
            //AddEmployee(3088685, "Joost", "Burggraaff", 'M', DateTime.ParseExact("18/09/1997", format, cultureInf), "", "", "3088685", "Eindhoven", "g.wood@gmail.com", DateTime.ParseExact("11/11/2020", format, cultureInf), DateTime.ParseExact("11/05/2021", format, cultureInf), PositionType.Depot_Worker, Departments.warehouse, 1);
        }

    }
}

