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
            this.ConnString = "Server=studmysql01.fhict.local;Uid=dbi453373;Database=dbi453373;Pwd=12345";
            //this.ConnString = "Server=localhost;Uid=root;Database=dbi453373;Pwd=123";
            // Server=studmysql01.fhict.local;Uid=dbi453373;Database=dbi453373;Pwd=yourPassword;
            //conn = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi453373;Database=dbi453373;Pwd=12345;");

        }

        // Employees
        public void AddEmployee(string fname, string lname, DateTime dateOfBirth, Gender gender, string email,
            string phone, string street, string city, string country, string postcode, string bsn,
            string emConName, EmergencyContactRelation emConRelation, string emConEmail, string emConPhone,
            EmploymentType empType, double hourlyWages, Department department)
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

                    cmd.Parameters.AddWithValue("@fname", fname);
                    cmd.Parameters.AddWithValue("@lname", lname);
                    cmd.Parameters.AddWithValue("@dob", dateOfBirth);

                    cmd.Parameters.AddWithValue("@gender", Convert.ToInt32(gender) + 1);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);

                    cmd.Parameters.AddWithValue("@street", street);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@country", country);

                    cmd.Parameters.AddWithValue("@postcode", postcode);
                    cmd.Parameters.AddWithValue("@bsn", bsn);
                    cmd.Parameters.AddWithValue("@emConName", emConName);
                    cmd.Parameters.AddWithValue("@emConRelation", Convert.ToInt32(emConRelation) + 1);
                    cmd.Parameters.AddWithValue("@emConEmail", emConEmail);
                    cmd.Parameters.AddWithValue("@emConPhone", emConPhone);

                    int employmentTypeInt = 0;
                    if (empType == EmploymentType.FULLTIME)
                    {
                        employmentTypeInt = 1;
                    }
                    else if (empType == EmploymentType.PARTTIME1)
                    {
                        employmentTypeInt = 2;
                    }
                    else
                    {
                        employmentTypeInt = 3;
                    }

                    cmd.Parameters.AddWithValue("@employmentType", employmentTypeInt);
                    cmd.Parameters.AddWithValue("@hourlyWages", hourlyWages);
                    cmd.Parameters.AddWithValue("@depId", department.Id);


                    cmd.Parameters.AddWithValue("@remainingHolidayDays", 50);

                    conn.Open();

                    int effectedRows = cmd.ExecuteNonQuery();
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
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //Stocks
        public void AddStock(string model, string brand, double price, int quantity, double height,
            double width, double depth, double weight, string shortDescription)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {
                    string sql = "INSERT INTO stock (Brand, Model, Quantity, Price, " +
                                 "Width, Height, Depth, Weight, ShortDescription) " +
                                 "VALUES(@brand, @model, @quantity, @price, @width, @height, @depth, " +
                                 "@weight, @description)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@brand", brand);
                    cmd.Parameters.AddWithValue("@model", model);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@width", width);
                    cmd.Parameters.AddWithValue("@height", height);
                    cmd.Parameters.AddWithValue("@depth", depth);
                    cmd.Parameters.AddWithValue("@weight", weight);
                    cmd.Parameters.AddWithValue("@description", shortDescription);

                    conn.Open();

                    int effectedRows = cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void RemoveStock(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {

                    string sql = "DELETE from stock WHERE id=@id";


                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", id);


                    conn.Open();

                    int effectedRows = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateStockQuantity(Stock stock)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {

                    string sql = "UPDATE stock set Quantity=@quantity " +
                                 "WHERE id=@id";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@quantity", stock.Quantity);
                    cmd.Parameters.AddWithValue("@id", stock.Id);

                    conn.Open();

                    int effectedRows = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //:TODO: Made edit stock
        public void EditStock(Stock stock)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {

                    string sql = "UPDATE stock " +
                                 "set Brand = @brand, " +
                                 "Model = @model, " +
                                 "Quantity = @quantity, " +
                                 "Price = @price, " +
                                 "Width = @width, " +
                                 "Height = @height, " +
                                 "Depth = @depth, " +
                                 "Weight = @weight, " +
                                 "ShortDescription = @description " +
                                 "WHERE id=@id";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@brand", stock.Brand);
                    cmd.Parameters.AddWithValue("@model", stock.Model);
                    cmd.Parameters.AddWithValue("@quantity", stock.Quantity);
                    cmd.Parameters.AddWithValue("@price", stock.Price);
                    cmd.Parameters.AddWithValue("@width", stock.Width);
                    cmd.Parameters.AddWithValue("@height", stock.Height);
                    cmd.Parameters.AddWithValue("@depth", stock.Depth);
                    cmd.Parameters.AddWithValue("@weight", stock.Weight);
                    cmd.Parameters.AddWithValue("@description", stock.ShortDescription);
                    cmd.Parameters.AddWithValue("@id", stock.Id);

                    conn.Open();

                    int effectedRows = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void GetStocks(StockManagement stockManagement)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {

                    string sql = "SELECT * FROM stock";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        int id = Convert.ToInt32(dr[0]);
                        string brand = dr[1].ToString();
                        string model = dr[2].ToString();
                        int quantity = Convert.ToInt32(dr[3]);
                        double price = Convert.ToDouble(dr[4]);
                        double width = Convert.ToDouble(dr[5]);
                        double height = Convert.ToDouble(dr[6]);
                        double depth = Convert.ToDouble(dr[7]);
                        double weight = Convert.ToDouble(dr[8]);
                        string description = dr[9].ToString();

                        stockManagement.AddStock(id, model, brand, price, quantity, height, width, depth,
                            weight, description);


                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        // Departments
        public void AddDepartment(string name)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {
                    string sql = "INSERT INTO department (Name) VALUES(@name)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@name", name);


                    conn.Open();

                    int effectedRows = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void AddDepartment(string name, Employee manager)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {
                    string sql = "INSERT INTO department (IDManager, Name) " +
                                 "VALUES(@idManager, @name)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@idManager", manager.Id);
                    cmd.Parameters.AddWithValue("@name", name);

                    conn.Open();

                    int effectedRows = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void RemoveDepartment(string name)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {
                    string sql = "DELETE from department WHERE name=@name";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@name", name);


                    conn.Open();

                    int effectedRows = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateDepartment(int id, string name, int idManager)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {

                    string sql = "UPDATE department " +
                                 "set Name=@name, " +
                                 "IDManager=@idManager " +
                                 "where ID=@id";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);


                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@IDManager", idManager);

                    conn.Open();

                    int effectedRows = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateDepartment(int id, string name)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {

                    string sql = "UPDATE department " +
                                 "set Name=@name " +
                                 "where ID=@id";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);


                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);

                    conn.Open();

                    int effectedRows = cmd.ExecuteNonQuery();
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

                    string sql = "SELECT d.IDManager, d.Name as 'DepName', emDep.Name as 'EmpDepName' " +
                                 "from department as d " +
                                 "inner join employee as e " +
                                 "on e.ID = d.IDManager " +
                                 "inner join department as emDep " +
                                 "on emDep.ID = e.DepartmentID " +
                                 "where d.IDManager is not NULL";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        
                        int idManager = Convert.ToInt32(dr[0]);
                        string depName = dr[1].ToString();
                        string empDepName = dr[2].ToString();

                        Department emDep = departmentManagement.GetDepartment(empDepName);
                        Department dep = departmentManagement.GetDepartment(depName);
                        Employee manager = emDep.GetEmployeeById(idManager);
                        dep.Manager = manager;
                        
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        // Shifts

        public void AddShift(ShiftType type, DateTime date, int assignedBy, bool wfh, Employee emp)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {
                    string sql = "INSERT INTO shift (EmployeeID, Date, AssignedByID, HasAttended, NoShowReason, Type, wfh) " +
                                 "VALUES(@empID, @date, @assignedBy, @hasAttended, @noShowReason, @type, @wfh)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@empID", emp.Id);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@assignedBy", assignedBy);
                    cmd.Parameters.AddWithValue("@hasAttended", true);
                    cmd.Parameters.AddWithValue("@noShowReason", null);
                    cmd.Parameters.AddWithValue("@type", Convert.ToInt32(type) + 1);
                    cmd.Parameters.AddWithValue("@wfh", wfh);

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

                        Shift s = departmentManagement.GetDepartment(depName).GetEmployeeById(employeeID).GetShift(id);

                        if (s == null)
                        {
                            departmentManagement.GetDepartment(depName).GetEmployeeById(employeeID).AddShift(id, type, date, assignedBy, wfh);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        // Shelf restock requests

        public void AddShelfRestockRequest(Stock stock, int quantity, int senderID, SRRstatus status)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {
                    string sql = "INSERT INTO shelfrestockrequest (StockID, RequestedQuantity, SenderID, Status) " +
                                 "VALUES(@stockID, @requestedQuantity, @senderID, @status)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@stockID", stock.Id);
                    cmd.Parameters.AddWithValue("@requestedQuantity", quantity);
                    cmd.Parameters.AddWithValue("@senderID", senderID);
                    cmd.Parameters.AddWithValue("@status", Convert.ToInt32(status) + 1);

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

        public void UpdateShelfRestockStatus(ShelfRestockRequest srr, SRRstatus status, SalesManagement salesManagement)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {
                    string sql = "UPDATE shelfrestockrequest " +
                                 "set status = @status " +
                                 "where ID = @requestID";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@requestID", srr.ID);
                    cmd.Parameters.AddWithValue("@status", Convert.ToInt32(status) + 1);

                    srr.Status = status;

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

                        ShelfRestockRequest srr = salesManagement.GetSRR(id);

                        if (srr == null)
                        {
                            salesManagement.AddRequest(id, stockManagement.GetStock(stockID), requestedQuantity, senderID, status);

                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


    }
}
