using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    public class EmployeeManager
    {
        private static List<Employee> employees;


        //Need these methods below
        //If you Guys Update the code one Please Update My reference  here 

        public EmployeeManager()
        {

        }

        public void AddTestData()
        {
            employees = new List<Employee>();
            employees.Add(new Employee(3992616, "Shenghang", "Zhu", "male", 134556, DateTime.Parse("01/01/2020"), "Tilburg", "ICT", "employed", "Depot", "xxxx@gmail.com", 1, PositionType.Depot_Worker));
            employees.Add(new Employee(3376540, "David", "van Rijthoven ", "male", 134556, DateTime.Parse("01/01/2020"), "Eindhoven", "ICT", "employed", "Sale", "xxxx@gmail.com", 1, PositionType.Sales_Worker));
            employees.Add(new Employee(4090918, "Dzhurov", "M", "male", 134556, DateTime.Parse("01/01/2020"), "Amersfoort", "ICT", "employed", "Depot", "xxxx@gmail.com", 1, PositionType.Depot_Worker));
            employees.Add(new Employee(443892, "Mohammed", "Al-Eryani", "male", 134556, DateTime.Parse("01/01/2020"), "Den Haag", "ICT", "employed", "Sale", "xxxx@gmail.com", 1, PositionType.Sales_Worker));
            employees.Add(new Employee(3088685, "Joost", "Burggraaff", "male", 134556, DateTime.Parse("01/01/2020"), "Eindhoven", "ICT", "employed", "Depot", "xxxx@gmail.com", 1, PositionType.Depot_Worker));

        }
        public List<Employee> GetEmployees()
        {
            return employees;
        }
        public Employee GetEmployeeBybsn(int bsn)
        {
            foreach (Employee e in employees)
            {
                if (e.BSN == bsn)
                {
                    return e;
                }
            }
            return null;
        }

    }
}