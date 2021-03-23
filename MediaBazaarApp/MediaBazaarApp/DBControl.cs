﻿using System;
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
                    string sql = "INSERT INTO employee (FirstName, LastName, DateOfBirth, Gender, Email, PhoneNumber, Street, City, " +
                                 "Country, PostCode, BSN, EmergencyContactName, EmergencyContactRelation, " +
                                 "EmergencyContactEmail, EmergencyContactPhone, EmploymentType, HourlyWages, DepartmentID, " +
                                 "RemainingHolidayDays) " +
                                 "VALUES(@fname, @lname, @dob, @gender, @email, @phone, @street, @city, @country, @postcode, " +
                                 "@bsn, @emConName, @emConRelation, @emConEmail, @emConPhone, @employmentType, @hourlyWages, @depId, " +
                                 "@remainingHolidayDays)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@fname", emp.FirstName);
                    cmd.Parameters.AddWithValue("@lname", emp.LastName);
                    cmd.Parameters.AddWithValue("@dob", emp.DateOfBirth);

                    cmd.Parameters.AddWithValue("@gender", Convert.ToInt32(emp.Gender) + 1);
                    cmd.Parameters.AddWithValue("@email", emp.Email);
                    cmd.Parameters.AddWithValue("@phone", emp.PhoneNumber);

                    cmd.Parameters.AddWithValue("@street", emp.Street);
                    cmd.Parameters.AddWithValue("@city", emp.City);
                    cmd.Parameters.AddWithValue("@country", emp.Country);

                    cmd.Parameters.AddWithValue("@postcode", emp.Postcode);
                    cmd.Parameters.AddWithValue("@bsn", emp.Bsn);
                    cmd.Parameters.AddWithValue("@emConName", emp.EmConName);
                    cmd.Parameters.AddWithValue("@emConRelation", Convert.ToInt32(emp.EmConRelation) + 1);
                    cmd.Parameters.AddWithValue("@emConEmail", emp.EmConEmail);
                    cmd.Parameters.AddWithValue("@emConPhone", emp.EmConPhoneNum);

                    int employmentTypeInt = 0;
                    if (emp.EmploymentType == EmploymentType.FULLTIME)
                    {
                        employmentTypeInt = 1;
                    }
                    else if (emp.EmploymentType == EmploymentType.PARTTIME1)
                    {
                        employmentTypeInt = 2;
                    }
                    else
                    {
                        employmentTypeInt = 3;
                    }

                    cmd.Parameters.AddWithValue("@employmentType", employmentTypeInt);
                    cmd.Parameters.AddWithValue("@hourlyWages", emp.HourlyWages);
                    cmd.Parameters.AddWithValue("@depId", emp.Department.Id);


                    cmd.Parameters.AddWithValue("@remainingHolidayDays", emp.RemainingHolidayDays);

                    conn.Open();

                    int effectedRows = cmd.ExecuteNonQuery();
                    //MessageBox.Show("Successfully added an employee!");
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
                    //MessageBox.Show($"Successfully removed employee with id:{id}!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EditEmployee(Employee emp)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {
                    string sql = "UPDATE employee " +
                                 "set FirstName = @fname, " +
                                 "LastName = @lname, " +
                                 "DateOfBirth = @dob, " +
                                 "Gender = @gender, " +
                                 "Email = @email, " +
                                 "PhoneNumber = @phone, " +
                                 "Street = @street, " +
                                 "City = @city, " +
                                 "Country = @country, " +
                                 "PostCode = @postcode, " +
                                 "BSN = @bsn, " +
                                 "EmergencyContactName = @emConName, " +
                                 "EmergencyContactRelation = @emConRelation, " +
                                 "EmergencyContactEmail = @emConEmail, " +
                                 "EmergencyContactPhone = @emConPhone, " +
                                 "EmploymentType = @employmentType, " +
                                 "HourlyWages = @hourlyWages, " +
                                 "DepartmentID = @depId, " +
                                 "RemainingHolidayDays = @remainingHolidayDays " +
                                 "where id = @id";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@fname", emp.FirstName);
                    cmd.Parameters.AddWithValue("@lname", emp.LastName);
                    cmd.Parameters.AddWithValue("@dob", emp.DateOfBirth);

                    cmd.Parameters.AddWithValue("@gender", Convert.ToInt32(emp.Gender) + 1);
                    cmd.Parameters.AddWithValue("@email", emp.Email);
                    cmd.Parameters.AddWithValue("@phone", emp.PhoneNumber);

                    cmd.Parameters.AddWithValue("@street", emp.Street);
                    cmd.Parameters.AddWithValue("@city", emp.City);
                    cmd.Parameters.AddWithValue("@country", emp.Country);

                    cmd.Parameters.AddWithValue("@postcode", emp.Postcode);
                    cmd.Parameters.AddWithValue("@bsn", emp.Bsn);
                    cmd.Parameters.AddWithValue("@emConName", emp.EmConName);
                    cmd.Parameters.AddWithValue("@emConRelation", Convert.ToInt32(emp.EmConRelation) + 1);
                    cmd.Parameters.AddWithValue("@emConEmail", emp.EmConEmail);
                    cmd.Parameters.AddWithValue("@emConPhone", emp.EmConPhoneNum);

                    int employmentTypeInt = 0;
                    if (emp.EmploymentType == EmploymentType.FULLTIME)
                    {
                        employmentTypeInt = 1;
                    }
                    else if (emp.EmploymentType == EmploymentType.PARTTIME1)
                    {
                        employmentTypeInt = 2;
                    }
                    else
                    {
                        employmentTypeInt = 3;
                    }

                    cmd.Parameters.AddWithValue("@employmentType", employmentTypeInt);
                    cmd.Parameters.AddWithValue("@hourlyWages", emp.HourlyWages);
                    cmd.Parameters.AddWithValue("@depId", emp.Department.Id);
                    cmd.Parameters.AddWithValue("@remainingHolidayDays", emp.RemainingHolidayDays);

                    cmd.Parameters.AddWithValue("@id", emp.Id);


                    conn.Open();

                    int effectedRows = cmd.ExecuteNonQuery();
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

        public void GetDepartments(DepartmentManagement departmentManagement)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {
                    string sql = "SELECT ID, Name FROM department";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        int id = Convert.ToInt32(dr[0]);

                        string depName = dr[1].ToString();
                        departmentManagement.AddDepartment(depName);
                        Department currDep = departmentManagement.GetDepartment(depName);
                        currDep.Id = id;

                    }
                    MessageBox.Show("Successfully get deparmtents!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void GetEmployees(DepartmentManagement departmentManagement)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {

                    string sql = "SELECT e.*, d.Name FROM employee as e " +
                                 "inner join department as d " +
                                 "on e.DepartmentID = d.ID";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        int id = Convert.ToInt32(dr[0]);
                        string fname = dr[1].ToString();
                        string lname = dr[2].ToString();
                        DateTime dob = (DateTime)dr[3];
                        Gender gender = (Gender)Enum.Parse(typeof(Gender), dr[4].ToString());
                        string email = dr[5].ToString();
                        string phone = dr[6].ToString();
                        string street = dr[7].ToString();
                        string city = dr[8].ToString();
                        string country = dr[9].ToString();
                        string postcode = dr[10].ToString();
                        string bsn = dr[11].ToString();
                        string emConName = dr[12].ToString();
                        EmergencyContactRelation emConRelation = (EmergencyContactRelation)Enum.Parse(typeof(EmergencyContactRelation), dr[13].ToString());
                        string emConEmail = dr[14].ToString();
                        string emConPhone = dr[15].ToString();
                        EmploymentType employmentType = (EmploymentType)Enum.Parse(typeof(EmploymentType), dr[16].ToString());
                        double hourlyWages = Convert.ToDouble(dr[17]);
                        int depId = Convert.ToInt32(dr[18]);
                        int remainingHolidayDays = Convert.ToInt32(dr[19]);
                        string depName = dr[20].ToString();

                        Department dep = departmentManagement.GetDepartment(depName);
                        dep.AddEmployee(fname, lname, dob, gender, email, phone,
                            street, city, country, postcode, bsn, emConName, emConRelation, emConEmail,
                            emConPhone, employmentType, hourlyWages, dep);
                        dep.GetEmployeeByEmail(email).Id = id;
                        dep.GetEmployeeByEmail(email).RemainingHolidayDays = remainingHolidayDays;

                    }
                    MessageBox.Show("Successfully get employees!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void SetDepartmentManagers(DepartmentManagement departmentManagement)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {

                    string sql = "SELECT IDManager, Name " +
                                 "from department";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (!String.IsNullOrEmpty(dr[0].ToString()))
                        {
                            int idManager = Convert.ToInt32(dr[0]);
                            string depName = dr[1].ToString();

                            Department dep = departmentManagement.GetDepartment(depName);
                            Employee manager = dep.GetEmployeeById(idManager);
                            dep.Manager = manager;
                        }

                    }
                    MessageBox.Show("Successfully set managers!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        // Shifts

        public void AddShift(Shift shift, Employee emp)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {
                    string sql = "INSERT INTO shift (EmployeeID, Date, AssignedByID, HasAttended, NoShowReason, Type, wfh) " +
                                 "VALUES(@empID, @date, @assignedBy, @hasAttended, @noShowReason, @type, @wfh)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@empID", emp.Id);
                    cmd.Parameters.AddWithValue("@date", shift.Date);
                    cmd.Parameters.AddWithValue("@assignedBy", shift.AssignedBy);
                    cmd.Parameters.AddWithValue("@hasAttended", shift.HasAttended);
                    cmd.Parameters.AddWithValue("@noShowReason", shift.NoShowReason);
                    cmd.Parameters.AddWithValue("@type", Convert.ToInt32(shift.Type) + 1);
                    cmd.Parameters.AddWithValue("@wfh", shift.WFH);

                    conn.Open();

                    int effectedRows = cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully added a shift!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void RemoveShift(Shift shift)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {

                    string sql = "DELETE from shift WHERE id=@id";


                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", shift.ID);


                    conn.Open();

                    int effectedRows = cmd.ExecuteNonQuery();
                    MessageBox.Show($"Successfully removed a shift!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void GetShifts(DepartmentManagement departmentManagement)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {

                   string sql = "SELECT s.*, d.Name FROM shift as s " +
                        "inner join employee as e " +
                        "on s.EmployeeID = e.ID " +
                        "inner join department as d " +
                        "on e.DepartmentID = d.ID";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        int id = Convert.ToInt32(dr[0]);
                        int employeeID = Convert.ToInt32(dr[1]);
                        DateTime date = (DateTime)dr[2];
                        int assignedBy = Convert.ToInt32(dr[3]);
                        ShiftType type = (ShiftType)Enum.Parse(typeof(ShiftType), dr[6].ToString());
                        bool wfh = Convert.ToBoolean(dr[7]);
                        string depName = dr[8].ToString();

                        departmentManagement.GetDepartment(depName).GetEmployeeById(employeeID).AddShift(type, date, assignedBy, wfh);

                        

                    }
                    MessageBox.Show("Successfully got shifts!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        // Shelf restock requests

        public void AddShelfRestockRequest(ShelfRestockRequest srr)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {
                    string sql = "INSERT INTO shelfrestockrequest (StockID, RequestedQuantity, SenderID, Status) " +
                                 "VALUES(@stockID, @requestedQuantity, @senderID, @status)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@stockID", srr.Stock.Id);
                    cmd.Parameters.AddWithValue("@requestedQuantity", srr.RequestedQuantity);
                    cmd.Parameters.AddWithValue("@senderID", srr.SenderID);
                    cmd.Parameters.AddWithValue("@status", Convert.ToInt32(srr.Status) + 1);

                    conn.Open();

                    int effectedRows = cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully added a shelf restock request!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void RemoveShelfRestockRequest(ShelfRestockRequest ssr)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {

                    string sql = "DELETE from shelfrestockrequest WHERE id=@id";


                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", ssr.ID);


                    conn.Open();

                    int effectedRows = cmd.ExecuteNonQuery();
                    MessageBox.Show($"Successfully removed a shelf restock request!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateShelfRestockStatus(ShelfRestockRequest srr, SRRstatus status)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {
                    string sql = "UPDATE shelfrestockrequest " +
                                 "set status = @status " +
                                 "where id = @requestID";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@requestID", srr.ID);
                    cmd.Parameters.AddWithValue("@status", Convert.ToInt32(srr.Status) + 1);


                    conn.Open();

                    int effectedRows = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetShelfRestockRequests(SalesManagement salesManagement, StockManagement stockManagement)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {

                    string sql = "SELECT * FROM shelfrestockrequest ";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        int id = Convert.ToInt32(dr[0]);
                        int stockID = Convert.ToInt32(dr[1]);
                        int requestedQuantity = Convert.ToInt32(dr[2]);
                        int senderID = Convert.ToInt32(dr[3]);
                        SRRstatus status = (SRRstatus)Enum.Parse(typeof(SRRstatus), dr[4].ToString());

                        salesManagement.AddRequest(stockManagement.GetStock(stockID), requestedQuantity, senderID);
                    }
                    MessageBox.Show("Successfully got shelf stock requests!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


    }
}