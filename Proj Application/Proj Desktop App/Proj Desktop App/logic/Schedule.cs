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
        private static List<AvailableShift> availableShifts; //not in use as of yet

        public Schedule()
        {
        }

        public List<AssignedShift> GetAssignedShifts()
        {
            return assignedShifts;
        }
        public List<AvailableShift> GetAvailableShifts()
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
            EmployeeStorage a = new EmployeeStorage();
            if (assignedShifts is null) { assignedShifts = new List<AssignedShift>(); }
            else { assignedShifts.Clear(); }

            if (availableShifts is null) { availableShifts = new List<AvailableShift>(); }
            else { availableShifts.Clear(); }

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
                sql = $"SELECT * FROM `preferedschdule` WHERE year(dateShift)='{date.ToString("yyyy")}' AND month(dateShift)='{date.ToString("MM")}';";
                cmd = new MySqlCommand(sql,conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[2].ToString() == "Morning") { shifttype = ShiftType.Morning; }
                    else if (dr[2].ToString() == "Afternoon") { shifttype = ShiftType.Afternoon; }
                    else if (dr[2].ToString() == "Evening") { shifttype = ShiftType.Evening; }
                    else if (dr[2].ToString() == "Morning_Afternoon") { shifttype = ShiftType.Morning_Afternoon; }
                    else if (dr[2].ToString() == "Afternoon_Evening") { shifttype = ShiftType.Afternoon_Evening; }
                    else if (dr[2].ToString() == "Morning_Evening") { shifttype = ShiftType.Morning_Evening; }
                    availableShifts.Add(new AvailableShift(a.GetEmployee(Convert.ToInt32(dr[0])), (DateTime)dr[1], shifttype));
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                assignedShifts = new List<AssignedShift>();
                availableShifts = new List<AvailableShift>();
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



    }
}