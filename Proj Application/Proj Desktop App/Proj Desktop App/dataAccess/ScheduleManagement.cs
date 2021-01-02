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
    class ScheduleManagement : DatabaseConnection
    {
        private string sqlstatements;
        public ScheduleManagement() 
        {
            sqlstatements = "";
        }
        /// <summary>
        ///Specify the day
        ///This function will  
        ///Load this month of schdule data from database
        /// </summary>
        public List<Availability> LoadAvailability(EmployeeStorage empStorage)
        {
            //to get the employee object, couble be change in the future;
            MySqlConnection conn = base.GetConnection();
            string sql = $"SELECT * FROM availability;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            List<Availability> availabilities = new List<Availability>();
            try
            {
                
                conn.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                List<ShiftType> weeklyavailbility = new List<ShiftType>();
                Employee emp;
                
                while (dr.Read())
                {
                    //1.Get emloyee
                    emp = empStorage.GetEmployee(Convert.ToInt32(dr[0]));
                    weeklyavailbility.Clear();
                    //2.Formulate ShiftType
                    for (int i = 1; i <= 5; i++)
                    {
                        if (dr[i].ToString() == "Morning") { weeklyavailbility.Add(ShiftType.Morning); }
                        else if (dr[i].ToString() == "Afternoon") { weeklyavailbility.Add(ShiftType.Afternoon); }
                        else if (dr[i].ToString() == "Evening") { weeklyavailbility.Add(ShiftType.Evening); }
                        else if (dr[i].ToString() == "Morning_Afternoon") { weeklyavailbility.Add(ShiftType.Morning_Afternoon); }
                        else if (dr[i].ToString() == "Afternoon_Evening") { weeklyavailbility.Add(ShiftType.Afternoon_Evening); }
                        else if (dr[i].ToString() == "Morning_Evening") { weeklyavailbility.Add(ShiftType.Morning_Evening); }
                        else if (dr[i].ToString() == "FullDay") { weeklyavailbility.Add(ShiftType.FullDay); }
                        else { weeklyavailbility.Add(ShiftType.None); }
                    }
                    //3.Adding Aailibility
                    availabilities.Add(new Availability(emp, weeklyavailbility.ToArray()));
                }
                return availabilities;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<AssignedShift> LoadAssignedShifts(DateTime date, EmployeeStorage empStorage)
        {
            DateTime bufferdataforautomaticassignedshift = date.AddDays(40);
            string sql = $"SELECT * FROM `assignedschdule` WHERE date BETWEEN '{date.ToString("yyyy-MM-01")}' AND '{bufferdataforautomaticassignedshift.ToString("yyyy-MM-dd")}';";
            List<AssignedShift> assignedShifts = new List<AssignedShift>();
            MySqlConnection conn = base.GetConnection();
            try
            {
                
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
                    assignedShifts.Add(new AssignedShift(empStorage.GetEmployee(Convert.ToInt32(dr[0])), (DateTime)dr[1], shifttype));
                }
                return assignedShifts;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// Update the shift data to the database
        /// </summary>
        /// <param name="UpdatedShifts">Application Side Assigned Shift Lists after user assign shifts</param>
        public string UpDateAssignedShift()
        {
            string feedback = "";
            if (sqlstatements == "") { feedback = ""; }
            else {
                MySqlConnection conn = base.GetConnection();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sqlstatements, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    feedback = "Update completed";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    feedback = "Update failed";
                }
                finally
                {
                    sqlstatements = "";
                    conn.Close();
                }
            }
            return feedback;
        }
        public void ChangeShiftType(ShiftType shiftype, int bsn, DateTime date)
        {
            sqlstatements += $"UPDATE `assignedschdule` SET `assigned_shift_type`= '{shiftype.ToString()}' WHERE BSN ='{bsn}' AND date='{date.ToString("yyyy-MM-dd")}';";
        }
        public void AddNewShift(ShiftType shiftype, int bsn, DateTime date)
        {
            sqlstatements += $"INSERT INTO `assignedschdule` (`BSN`, `date`, `assigned_shift_type`) VALUES('{bsn}', '{date.ToString("yyyy-MM-dd")}', '{shiftype.ToString()}');";
        }

        public void RemoveAssignedShift(int bsn,DateTime date)
        {
            sqlstatements+=$"DELETE FROM `assignedschdule` WHERE date='{date.ToString("yyyy-MM-dd")}' AND BSN='{bsn}';";
        }

    }
}