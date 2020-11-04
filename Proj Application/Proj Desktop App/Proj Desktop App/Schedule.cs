using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;
namespace Proj_Desktop_App
{
    class Schedule
    {
        //draft class right now
        //we either safe everything in this class and display any date that is asked for
        //or this class gets filled for the date and there is another entity (class/db) that has everything in it and sorts it per date
        //currently this is the collection class with all the info

        private static List<AssignedShift> assignedShifts;
        private static List<AvailableShifts> availableShifts; //not in use as of yet

        public Schedule(List<AssignedShift> AssignedShifts)
        {
            assignedShifts = AssignedShifts;
        }
        public Schedule(string test)
        {
            //mock data still needs to be done
        }


        public Schedule()
        {
        }

        public List<AssignedShift> GetAssignedShifts()
        {
            return assignedShifts;
        }
        public List<AvailableShifts> GetAvailableShifts()
        {
            return availableShifts;
        }



        /// <summary>
        ///Specify the day
        ///This function will  
        ///Load this month of schdule data from database
        /// </summary>
        public void LoadSchduleFormDateBase(DateTime date)
        {   //to get the employee object, couble be change in the future;
            Store a = new Store();
            if (assignedShifts is null) { assignedShifts = new List<AssignedShift>(); }
            else { assignedShifts.Clear(); }
            string sql = $"SELECT * FROM `assignedschdule` WHERE year(date)='{date.ToString("yyyy")}' AND month(date)='{date.ToString("MM")}';";
            try
            {
                MySqlConnection conn = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi443880;Database=dbi443880;Pwd=123456");
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                ShiftType shifttype = ShiftType.Morning;
                while (dr.Read())
                {
                    if (dr[2].ToString() == "Morning") { shifttype = ShiftType.Morning; }   
                    else if (dr[2].ToString() == "Afternoon") { shifttype = ShiftType.Afternoon; }
                    else if (dr[2].ToString() == "Evening") { shifttype = ShiftType.Evening; }
                    else if (dr[2].ToString() == "Morning_Afternoon") { shifttype = ShiftType.Morning_Afternoon; }
                    else if (dr[2].ToString() == "Afternoon_Evening") { shifttype = ShiftType.Afternoon_Evening; }
                    else if (dr[2].ToString() == "Morning_Evening") { shifttype = ShiftType.Morning_Evening; }
                    assignedShifts.Add(new AssignedShift(a.GetEmployee(Convert.ToInt32(dr[0])), (DateTime)dr[1], shifttype));
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }
        /// <summary>
        /// Update the shift data to the database
        /// </summary>
        /// <param name="UpdatedShifts"></param>
        public void UpDateSchdule(List<AssignedShift> shifts,List<string> sql)
        {

            string sqlstatement = "";
            foreach (string x in sql)
            {
                sqlstatement += x;
            }
            if (sqlstatement == "") { return; }
            MySqlConnection conn = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi443880;Database=dbi443880;Pwd=123456");
            try {
                MySqlCommand cmd = new MySqlCommand(sqlstatement, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                assignedShifts = shifts;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }        
        }


        //no check on preffered shifts yet
        //would take  this from available shifts to assigned shifts later. if we implement that way of functioning with the schedule
        public AssignedShift AddShift(Employee employee, DateTime shiftDateTimeStart, ShiftType shiftType)
        {
            AssignedShift assignedShift = new AssignedShift(employee, shiftDateTimeStart, shiftType);
            assignedShifts.Add(assignedShift);
            return assignedShift;
        }

        public AssignedShift RemoveShift(AssignedShift removeShift)
        {
            assignedShifts.Remove(removeShift);
            return removeShift;

        }

        public AssignedShift RemoveShift(Employee employee, DateTime shiftDateTimeStart, ShiftType shiftType)
        {
            AssignedShift removeShift = new AssignedShift(employee, shiftDateTimeStart, shiftType);
            assignedShifts.Remove(removeShift);
            return removeShift;
        }

        //not adapted to schedule manager yet
        public void UpdateShift(AssignedShift changeShift, Employee employee, DateTime shiftDateTimeStart, DateTime shiftDateTimeEnd, ShiftType shiftType)
        {
            AssignedShift changedShift = new AssignedShift(employee, shiftDateTimeStart, shiftType);

            foreach (AssignedShift shift in assignedShifts)
            {
                if (shift == changeShift)
                {
                    assignedShifts.Remove(shift);
                    assignedShifts.Add(changedShift);
                }
            }
        }

        //obsolete with the schedule manager? everything under this
        public AssignedShift GetShift(Employee employee, DateTime shiftDateTimeStart, ShiftType shiftType)
        {
            string emptyShift = "null";
            AssignedShift getShift = new AssignedShift(employee, shiftDateTimeStart, shiftType);
            AssignedShift nullShift = new AssignedShift(emptyShift);

            foreach (AssignedShift shift in assignedShifts)
            {
                if (shift == getShift)
                {
                    return shift;
                }
            }

            return nullShift;
        }

        public AssignedShift GetShift(AssignedShift getShift)
        {
            string emptyShift = "null";
            AssignedShift nullShift = new AssignedShift(emptyShift);

            foreach (AssignedShift shift in assignedShifts)
            {
                if (shift == getShift)
                {
                    return shift;
                }
            }

            return nullShift;
        }
    }
}