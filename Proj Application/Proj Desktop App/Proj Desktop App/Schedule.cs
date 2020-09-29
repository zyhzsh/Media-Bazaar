using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Desktop_App
{
    class Schedule
    {
        List<AssignedShift> assignedShifts;
        public Schedule()
        {
            //Read for somewhere or database
            assignedShifts = new List<AssignedShift>();
       
        }
        public  bool AssignEmployeeToShift(ShiftType shiftType,string selecteddate,List<Employee>employees)
        {  
            foreach (AssignedShift e in assignedShifts)
            {
                assignedShifts.Add(new AssignedShift(selecteddate,shiftType,employees));
            }   
            return true;        
        }

        public bool AssignEmployeeToShift(ShiftType shiftType, string selecteddate, Employee employee)
        {

            ////情况一：所选的日期没有返回值
            //if (GetAssignedEmployees(selecteddate).Count() == 0)
            //{
            //    assignedShifts.Add(new AssignedShift(selecteddate, shiftType, employee));
            //}
            ////情况二：所选日期有返回值
            //else {
            //    List<Employee>emp = GetAssignedEmployees(selecteddate);

            //    //1.若是返回的值内部有这个员工
            //    if (emp.Contains(employee))
            //    { 
            //    //检测员工的shiftype是否一致
                


            //    //1.如果一致             
                
            //    }
            //}


            ////1.输入时间、和SHIFT类型、和员工
            ////2.通过输入的时间来获得当天的列表员工列表
            ////3.在此基础上更新
            //foreach (AssignedShift e in assignedShifts)
            //{
            //    if (e.SelectedDate == selecteddate)
            //    { 
                   
            //    }
            //}
            
            
            return true;

        }







        public bool RemoveFromShift(ShiftType shiftType, DateTime selecteddate, List<string> employee_bsn)
        { 
            return false;
        }

        public List<Employee> GetAssignedEmployees(string seleteddate)
        {
            List<Employee> tempo_empolyees = new List<Employee>();  
            foreach (AssignedShift e in assignedShifts)
            {
                if (e.SelectedDate == seleteddate)
                {
                    tempo_empolyees = e.GetShiftsList();
                }          
            }
            return tempo_empolyees;
        }




        public List<Shift> GetAvailableEmployees(DateTime seleteddate)
        {
            return null;
        }

     
























    }
}
