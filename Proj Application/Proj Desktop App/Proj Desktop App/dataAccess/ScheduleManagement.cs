using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Proj_Desktop_App.dataAccess
{
    class ScheduleManagement: DatabaseConnection
    {

        private static List<AssignedShift> assignedShifts;
        private static List<Availability> availableShifts;
        public ScheduleManagement() { }
        public List<AssignedShift> GetAssignedShifts()
        {
            return assignedShifts;
        }
        public List<Availability> GetAvailableShifts()
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

            if (availableShifts is null) { availableShifts = new List<PreferenceShift>(); }
            else { availableShifts.Clear(); }

            string sql = $"SELECT * FROM `assignedschdule` WHERE year(date)='{date.ToString("yyyy")}' AND month(date)='{date.ToString("MM")}';";
            try
            {
                MySqlConnection conn = base.GetConnection();
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
                cmd = new MySqlCommand(sql, conn);
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
                    availableShifts.Add(new PreferenceShift(a.GetEmployee(Convert.ToInt32(dr[0])), (DateTime)dr[1], shifttype));
                }
                conn.Close();
                   
            }
            catch (Exception ex)
            {
                assignedShifts = new List<AssignedShift>();
                availableShifts = new List<PreferenceShift>();
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
            MySqlConnection conn = base.GetConnection();
            try 
            {
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