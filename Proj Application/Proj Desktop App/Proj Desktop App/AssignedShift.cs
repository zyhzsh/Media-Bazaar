<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    class AssignedShift : EmployeeShift
    {

        public AssignedShift(Employee employee, DateTime date, ShiftType shiftType)
        {
            this.employee = employee;
            this.date = date;
            this.shiftType = shiftType;
        }
        public override Employee GetEmployee() { return this.employee; }
        public override DateTime GetDate() { return this.date; }
        public override ShiftType GetShiftType() { return this.shiftType; }
        public void UpDateShift(ShiftType shiftType) { this.shiftType = shiftType; }

        public string GetShiftTypeToString()
        {
            switch (shiftType)
            {
                case ShiftType.Evening: return "Evening";
                case ShiftType.Morning: return "Monring";
                case ShiftType.Afternoon: return "Afternoon";
                case ShiftType.Morning_Afternoon: return "Monrning,Afternoon";
                case ShiftType.Morning_Evening: return "Monring,Evening";
                case ShiftType.Afternoon_Evening: return "Afternoon,Evening";
                case ShiftType.FullDay: return "FullDay";
            }
            return "";
        }

        


        //null shift
        public AssignedShift(string nullShift)
        {

        }

    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    class AssignedShift : EmployeeShift
    {

        public AssignedShift(Employee employee, DateTime shiftDateTimeStart, DateTime shiftDateTimeEnd, ShiftType shiftType) : base(employee, shiftDateTimeStart, shiftDateTimeEnd, shiftType)
        {

        }

    }
}
﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_Desktop_App
{
    class AssignedShift
    {
        List<Employee> assignedemployees=new List<Employee>();
        public string SelectedDate { get; set; }
        public ShiftType ShiftType { get; set; }
        //public AssignedShift(string selecteddate, ShiftType shiftType,List<Employee> employees):base(selecteddate,shiftType)
        //{
        //    //when assignemployees list is empty
        //    if (assignedemployees.Count() == 0)
        //    {
        //        //1.Read from file or database
        //        //2.Update to the list<employee>
        //        assignedemployees.AddRange(GetAssingedEmployeesByDate(selecteddate));
        //        //3.Check the Input List<emloyee> exsited in the current list or not
        //        SetShiftList(employees, shiftType);
        //    }
        //    else
        //    {
        //        SetShiftList(employees, shiftType);
        //    }
        // }




        public AssignedShift(string date, ShiftType shiftType, List<Employee> employees)
        {
            this.SelectedDate = date;
            this.ShiftType = shiftType;
            //when assignemployees list is empty
           if (assignedemployees.Count() == 0)
            {
                //1.Read from file or database
                //2.Update to the list<employee>
                assignedemployees.AddRange(GetAssingedEmployeesByDate(date));
                //3.Check the Input List<emloyee> exsited in the current list or not
                SetShiftList(employees, shiftType);
            }
            else
            {
                SetShiftList(employees, shiftType);
            }
        }



        public AssignedShift(string date, ShiftType shiftType, Employee employee)
        { 
            
        
        }


        private List<Employee> GetAssingedEmployeesByDate(string selecteddate)
        {
            //Read some where from database
            List<Employee> temp = new List<Employee>();
            //And Do something with list 
            return temp;
        }
        private void SetShiftList(List<Employee> employees, ShiftType shiftType)
        {
            foreach (Employee E in employees)
            {
                if (assignedemployees.Contains(E))
                {
                    //Update information to file、database or somewhere
                    UpdateEmployeeShift(shiftType, E.BSN);
                }
                else
                {
                    assignedemployees.Add(E);
                }
            }

        }
        public void UpdateEmployeeShift(ShiftType shiftType,int employee_bsn)
        { 
                 //Update to file/database or somewhere

        }



        public  List<Employee> GetShiftsList()
        {
            return this.assignedemployees;
        }

        

    }
}
>>>>>>> parent of 83ec41c... ScheduleManager implemented
