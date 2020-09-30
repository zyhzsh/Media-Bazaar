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
                    UpdateEmployeeShift(shiftType, E.GetBSN());
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
