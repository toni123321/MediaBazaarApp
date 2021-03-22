using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MediaBazaarApp
{
    public class DBControl
    {
        //private MySqlConnection conn;

        public string ConnString
        {
            get;
            set;
        }

        public DBControl(string connString)
        {
            this.ConnString = connString;
            //conn = new MySqlConnection(this.ConnString);

        }

        public DBControl()
        {
            this.ConnString = "Server=studmysql01.fhict.local;Uid=dbi453373;Database=dbi453373;Pwd=12345;";

            // Server=studmysql01.fhict.local;Uid=dbi453373;Database=dbi453373;Pwd=yourPassword;
            //conn = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi453373;Database=dbi453373;Pwd=12345;");

        }

        public void AddEmployee(Employee emp)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {
                    string sql = "INSERT INTO employee (FirstName, LastName, DateOfBirth, Gender, Email, PhoneNumber, Street, City," +
                                 "Country, PostCode, BSN, EmergencyContactName, EmergencyContactRelation, " +
                                 "EmergencyContactEmail, EmergencyContactPhone, EmploymentType, HourlyWages, " +
                                 "RemainingHolidayDays) " +
                                 "VALUES(@fname, @lname, @dob, @gender, @email, @phone, @street, @city, @country, @postcode," +
                                 "@bsn, @emConName, @emConRelation, @emConEmail, @emConPhone, @employmentType, @hourlyWages," +
                                 "@remainingHolidayDays)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    
                    cmd.Parameters.AddWithValue("@fname", emp.FirstName);
                    cmd.Parameters.AddWithValue("@lname", emp.LastName);
                    cmd.Parameters.AddWithValue("@dob", emp.DateOfBirth);

                    cmd.Parameters.AddWithValue("@gender", 1);
                    cmd.Parameters.AddWithValue("@email", emp.Email);
                    cmd.Parameters.AddWithValue("@phone", emp.PhoneNumber);

                    cmd.Parameters.AddWithValue("@street", emp.Street);
                    cmd.Parameters.AddWithValue("@city", emp.City);
                    cmd.Parameters.AddWithValue("@country", emp.Country);

                    cmd.Parameters.AddWithValue("@postcode", emp.Postcode);
                    cmd.Parameters.AddWithValue("@bsn", emp.Bsn);
                    cmd.Parameters.AddWithValue("@emConName", emp.EmConName);
                    cmd.Parameters.AddWithValue("@emConRelation", 1);
                    cmd.Parameters.AddWithValue("@emConEmail", emp.EmConEmail);
                    cmd.Parameters.AddWithValue("@emConPhone", emp.EmConPhoneNum);

                    cmd.Parameters.AddWithValue("@employmentType", 1);
                    cmd.Parameters.AddWithValue("@hourlyWages", emp.HourlyWages);
                    //cmd.Parameters.AddWithValue("@depID", emp.Department.Id);


                    cmd.Parameters.AddWithValue("@remainingHolidayDays", emp.RemainingHolidayDays);


                    conn.Open();

                    int effectedRows = cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully added an employee!");
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }

        }

        public void RemoveEmployee(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {

                    string sql = "DELETE from employee WHERE id=@id";


                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", id);


                    conn.Open();

                    int effectedRows = cmd.ExecuteNonQuery();
                    MessageBox.Show($"Successfully removed employee with id:{id}!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void AddDepartment(Department dep)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {
                    string sql = "INSERT INTO department (Name) VALUES(@name)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@name", dep.Name);
                    

                    conn.Open();

                    int effectedRows = cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully added a deparmtent!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateDepartment(int idManager)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {
                    
                    string sql = "UPDATE department set IDManager=@idManager";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@IDManager", idManager);


                    conn.Open();

                    int effectedRows = cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully updated this deparmtent!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

    }
}
