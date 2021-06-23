using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MediaBazaarApp;

namespace MediaBazaarApp
{
    public class DBControl
    {
        //private MySqlConnection conn;

        public string ConnString { get; set; }

        public DBControl(string connString)
        {
            this.ConnString = connString;
            //conn = new MySqlConnection(this.ConnString);

        }

        public DBControl()
        {
            this.ConnString =
                "Server=studmysql01.fhict.local;Uid=dbi453373;Database=dbi453373;Pwd=12345;convert zero datetime=True;";
            //this.ConnString = "Server=localhost;Uid=root;Database=dbi453373;Pwd=123";
            // Server=studmysql01.fhict.local;Uid=dbi453373;Database=dbi453373;Pwd=yourPassword;
            //conn = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi453373;Database=dbi453373;Pwd=12345;");

        }

        // Employees
        public void AddEmployee(string fname, string lname, DateTime dateOfBirth, string nationality, Gender gender,
            string email,
            string phone, string street, string city, string country, string postcode, string bsn,
            string emConName, EmergencyContactRelation emConRelation, string emConEmail, string emConPhone,
            EmploymentType empType, double hourlyWages, DateTime startDate, DateTime endDate, Department department)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {
                    string sql =
                        "INSERT INTO employee (FirstName, LastName, DateOfBirth, Nationality, Gender, Email, PhoneNumber, Street, City, " +
                        "Country, PostCode, BSN, EmergencyContactName, EmergencyContactRelation, " +
                        "EmergencyContactEmail, EmergencyContactPhone, EmploymentType, HourlyWages, StartDate, EndDate, " +
                        "DepartmentID) " +
                        "VALUES(@fname, @lname, @dob, @nationality, @gender, @email, @phone, @street, @city, @country, @postcode, " +
                        "@bsn, @emConName, @emConRelation, @emConEmail, @emConPhone, @employmentType, @hourlyWages, @startDate, " +
                        "@endDate, @depId)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@fname", fname);
                    cmd.Parameters.AddWithValue("@lname", lname);
                    cmd.Parameters.AddWithValue("@dob", dateOfBirth);
                    cmd.Parameters.AddWithValue("@nationality", nationality);



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
                    cmd.Parameters.AddWithValue("@startDate", startDate);

                    if (endDate == DateTime.MaxValue)
                    {
                        cmd.Parameters.AddWithValue("@endDate", null);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@endDate", endDate);
                    }

                    cmd.Parameters.AddWithValue("@depId", department.Id);

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
                                 "Nationality = @nationality, " +
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
                                 "StartDate = @startDate, " +
                                 "EndDate = @endDate, " +
                                 "DepartmentID = @depId " +
                                 "where id = @id";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@fname", emp.FirstName);
                    cmd.Parameters.AddWithValue("@lname", emp.LastName);
                    cmd.Parameters.AddWithValue("@dob", emp.DateOfBirth);
                    cmd.Parameters.AddWithValue("@nationality", emp.Nationality);


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
                    cmd.Parameters.AddWithValue("@startDate", emp.StartDate);
                    
                    
                    if (emp.EndDate == DateTime.MaxValue)
                    {
                        cmd.Parameters.AddWithValue("@endDate", null);

                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@endDate", emp.EndDate);
                    }

                    cmd.Parameters.AddWithValue("@depId", emp.Department.Id);
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


        public IList<Employee> GetEmployeesWithExpiringContracts(DepartmentManagement departmentManagement)
        {
            IList<Employee> employeeWithExpiredContract = new List<Employee>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {

                    string sql = "SELECT e.*, d.Name FROM employee as e " +
                                 "inner join department as d " +
                                 "on e.DepartmentID = d.ID " +
                                 "where EndDate < CURDATE()";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        int id = Convert.ToInt32(dr[0]);
                        string fname = dr[1].ToString();
                        string lname = dr[2].ToString();
                        DateTime dob = (DateTime)dr[3];
                        string nationality = dr[4].ToString();
                        Gender gender = (Gender)Enum.Parse(typeof(Gender), dr[5].ToString());
                        string email = dr[6].ToString();
                        string phone = dr[7].ToString();
                        string street = dr[8].ToString();
                        string city = dr[9].ToString();
                        string country = dr[10].ToString();
                        string postcode = dr[11].ToString();
                        string bsn = dr[12].ToString();
                        string emConName = dr[13].ToString();
                        EmergencyContactRelation emConRelation =
                            (EmergencyContactRelation)Enum.Parse(typeof(EmergencyContactRelation), dr[14].ToString());
                        string emConEmail = dr[15].ToString();
                        string emConPhone = dr[16].ToString();
                        EmploymentType employmentType =
                            (EmploymentType)Enum.Parse(typeof(EmploymentType), dr[17].ToString());
                        double hourlyWages = Convert.ToDouble(dr[18]);

                        DateTime startDate = (DateTime)dr[19];

                        DateTime endDate;
                        if (String.IsNullOrEmpty(dr[20].ToString()))
                        {
                            // try with datetime max value
                            endDate = DateTime.MaxValue;
                        }
                        else
                        {
                            endDate = (DateTime)dr[20];
                        }

                        int depId = Convert.ToInt32(dr[21]);

                        string depName = dr[22].ToString();
                        Department dep = departmentManagement.GetDepartment(depName);

                        Employee emp = new Employee(fname, lname, dob, nationality, gender, email, phone,
                            street, city, country, postcode, bsn, emConName, emConRelation, emConEmail,
                            emConPhone, employmentType, hourlyWages, startDate, endDate, dep);
                        emp.Id = id;
                        employeeWithExpiredContract.Add(emp);
                        
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return employeeWithExpiredContract;
        }

        public bool CheckCredentialsEmpWithExpiredContract(string email, int empId, string departmentName)
        {
            bool isCredentialsValid = false;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {

                    string sql = "SELECT count(*) FROM employee as e " +
                                 "inner join department as d " +
                                 "on e.DepartmentID = d.ID " +
                                 "where EndDate < CURDATE() and e.ID = @id " +
                                 "and e.Email = @email and d.Name = @depName";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", empId);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@depName", departmentName);

                    conn.Open();

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    isCredentialsValid = count == 1;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return isCredentialsValid;
        }

        public void GetEmployees(DepartmentManagement departmentManagement)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {

                    string sql = "SELECT e.*, d.Name FROM employee as e " +
                                 "inner join department as d " +
                                 "on e.DepartmentID = d.ID " +
                                 "where EndDate >= CURDATE() or EndDate is NULL";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        int id = Convert.ToInt32(dr[0]);
                        string fname = dr[1].ToString();
                        string lname = dr[2].ToString();
                        DateTime dob = (DateTime) dr[3];
                        string nationality = dr[4].ToString();
                        Gender gender = (Gender) Enum.Parse(typeof(Gender), dr[5].ToString());
                        string email = dr[6].ToString();
                        string phone = dr[7].ToString();
                        string street = dr[8].ToString();
                        string city = dr[9].ToString();
                        string country = dr[10].ToString();
                        string postcode = dr[11].ToString();
                        string bsn = dr[12].ToString();
                        string emConName = dr[13].ToString();
                        EmergencyContactRelation emConRelation =
                            (EmergencyContactRelation) Enum.Parse(typeof(EmergencyContactRelation), dr[14].ToString());
                        string emConEmail = dr[15].ToString();
                        string emConPhone = dr[16].ToString();
                        EmploymentType employmentType =
                            (EmploymentType) Enum.Parse(typeof(EmploymentType), dr[17].ToString());
                        double hourlyWages = Convert.ToDouble(dr[18]);

                        DateTime startDate = (DateTime) dr[19];

                        DateTime endDate;
                        if (String.IsNullOrEmpty(dr[20].ToString()))
                        {
                            // try with datetime max value
                            endDate = DateTime.MaxValue;
                        }
                        else
                        {
                            endDate = (DateTime) dr[20];
                        }

                        int depId = Convert.ToInt32(dr[21]);

                        string depName = dr[22].ToString();

                        Department dep = departmentManagement.GetDepartment(depName);
                        dep.AddEmployee(departmentManagement, fname, lname, dob, nationality, gender, email, phone,
                            street, city, country, postcode, bsn, emConName, emConRelation, emConEmail,
                            emConPhone, employmentType, hourlyWages, startDate, endDate, dep);
                        dep.GetEmployeeByEmail(email).Id = id;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void AcceptUpdateDetails(string todo)
        {
            // get emps
            // search for such an employee by id locally - if not display error
            // new emp - duplicate of an existing one + apply new changes
            // edit emp DB (newly created object)
            // delete entry from the table containing pending changes by id - new method to be created regarding this and called here
            // get emps
        }

        public void DeclineUpdateDetails(string todo)
        {
            // get emps
            // delete entry from the table containing pending changes by id - new method to be created regarding this and called here
        }


        //Stocks
        public void AddStock(string model, string brand, double price, int quantity, double height,
            double width, double depth, double weight, string shortDescription, StockManagement stockManagement)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {
                    Dictionary<string, bool> stockStorage = stockManagement.GetStorage();
                    string location = "";

                    string sql = "INSERT INTO stock (Brand, Model, Quantity, Price, " +
                                 "Width, Height, Depth, Weight, ShortDescription, Location, Discontinued) " +
                                 "VALUES(@brand, @model, @quantity, @price, @width, @height, @depth, " +
                                 "@weight, @description, @location, @discontinued)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);


                    foreach (KeyValuePair<string, bool> l in stockStorage)
                    {
                        if (stockStorage.All(loc => loc.Value == false))
                        {
                            MessageBox.Show("Your storage is full");
                        }

                        if (l.Value == true)
                        {
                            location = l.Key;


                            cmd.Parameters.AddWithValue("@brand", brand);
                            cmd.Parameters.AddWithValue("@model", model);
                            cmd.Parameters.AddWithValue("@quantity", quantity);
                            cmd.Parameters.AddWithValue("@price", price);
                            cmd.Parameters.AddWithValue("@width", width);
                            cmd.Parameters.AddWithValue("@height", height);
                            cmd.Parameters.AddWithValue("@depth", depth);
                            cmd.Parameters.AddWithValue("@weight", weight);
                            cmd.Parameters.AddWithValue("@description", shortDescription);
                            cmd.Parameters.AddWithValue("@location", location);
                            cmd.Parameters.AddWithValue("@discontinued", "No");


                            conn.Open();

                            int effectedRows = cmd.ExecuteNonQuery();
                            break;
                        }

                    }



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

                    string sql = "UPDATE stock SET Location=@location, Discontinued=@discontinued WHERE id=@id";


                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@location", "None");
                    cmd.Parameters.AddWithValue("@discontinued", "Yes");


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
            stockManagement.ClearAllStocks();
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
                        string location = dr[10].ToString();

                        stockManagement.AddStock(id, model, brand, price, quantity, height, width, depth,
                            weight, description, location);


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
                    if (idManager != -1)
                    {
                        cmd.Parameters.AddWithValue("@IDManager", idManager);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@IDManager", null);
                    }

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

                    //departmentManagement.RemoveAllDepartments();
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
                    string sql =
                        "INSERT INTO shift (EmployeeID, Date, AssignedByID, HasAttended, NoShowReason, Type, wfh) " +
                        "VALUES(@empID, @date, @assignedBy, @hasAttended, @noShowReason, @type, @wfh)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@empID", emp.Id);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@assignedBy", assignedBy);
                    cmd.Parameters.AddWithValue("@hasAttended", false);
                    cmd.Parameters.AddWithValue("@noShowReason", null);
                    cmd.Parameters.AddWithValue("@type", Convert.ToInt32(type) + 1);
                    cmd.Parameters.AddWithValue("@wfh", wfh);

                    conn.Open();

                    int effectedRows = cmd.ExecuteNonQuery();
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
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void EditShiftAttendance(bool hasAttended, string noShowReason, int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {

                    string sql = "UPDATE shift " +
                                 "set HasAttended = @hasAttended, " +
                                 "NoShowReason = @noShowReason " +
                                 "WHERE id=@id";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@hasAttended", hasAttended);
                    cmd.Parameters.AddWithValue("@noShowReason", noShowReason);
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

        public void GetShifts(DepartmentManagement departmentManagement)
        {
            foreach (Employee emp in departmentManagement.GetAllEmployees())
            {
                emp.Shifts.Clear();
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {

                    string sql = "SELECT s.*, d.Name FROM shift as s " +
                                 "inner join employee as e " +
                                 "on s.EmployeeID = e.ID " +
                                 "inner join department as d " +
                                 "on e.DepartmentID = d.ID " +
                                 "where e.EndDate >= CURDATE() or e.EndDate is NULL";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        int id = Convert.ToInt32(dr[0]);
                        int employeeID = Convert.ToInt32(dr[1]);
                        DateTime date = (DateTime) dr[2];
                        int assignedBy = Convert.ToInt32(dr[3]);
                        bool hasAttended = Convert.ToBoolean(dr[4]);
                        string noShowReason = dr[5].ToString();
                        ShiftType type = (ShiftType) Enum.Parse(typeof(ShiftType), dr[6].ToString());
                        bool wfh = Convert.ToBoolean(dr[7]);
                        string depName = dr[8].ToString();

                        Shift s = departmentManagement.GetDepartment(depName).GetEmployeeById(employeeID).GetShift(id);

                        if (s == null)
                        {
                            departmentManagement.GetDepartment(depName).GetEmployeeById(employeeID).AddShift(id, type,
                                date, assignedBy, wfh, hasAttended, noShowReason);
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
                        SRRstatus status = (SRRstatus) Enum.Parse(typeof(SRRstatus), dr[4].ToString());

                        ShelfRestockRequest srr = salesManagement.GetSRR(id);

                        if (srr == null)
                        {
                            salesManagement.AddRequest(id, stockManagement.GetStock(stockID), requestedQuantity,
                                senderID, status);

                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public IList<EditAccountRequest> GetEditAccountRequests()
        {
            IList<EditAccountRequest> editAccountRequests = new List<EditAccountRequest>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {

                    string sql = "SELECT * FROM pending_changed_details";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        int id = Convert.ToInt32(dr[0]);
                        int employeeId = Convert.ToInt32(dr[1]);
                        string email = dr[2].ToString();
                        string phone = dr[3].ToString();
                        string street = dr[4].ToString();
                        string city = dr[5].ToString();
                        string country = dr[6].ToString();
                        string postcode = dr[7].ToString();
                        string emConName = dr[8].ToString();
                        EmergencyContactRelation emConRelation =
                            (EmergencyContactRelation) Enum.Parse(typeof(EmergencyContactRelation), dr[9].ToString());
                        string emConEmail = dr[10].ToString();
                        string emConPhone = dr[11].ToString();
                        string status = dr[12].ToString();
                        DateTime requestDate = (DateTime) dr[13];

                        EditAccountRequest editAccountRequest = new
                            EditAccountRequest(id, employeeId, email, phone, street, city, country,
                                postcode, emConName, emConRelation, emConEmail,
                                emConPhone, status, requestDate);
                        editAccountRequests.Add(editAccountRequest);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return editAccountRequests;
        }

        public void UpdateEditAccountRequest(EditAccountRequest editAccountRequest)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {

                    string sql = "UPDATE pending_changed_details " +
                                 "set Email = @email, " +
                                 "PhoneNumber = @phone, " +
                                 "Street = @street, " +
                                 "City = @city, " +
                                 "Country = @country, " +
                                 "PostCode = @postcode, " +
                                 "EmergencyContactName = @emConName, " +
                                 "EmergencyContactRelation = @emConRelation, " +
                                 "EmergencyContactEmail = @emConEmail, " +
                                 "Status = @status, " +
                                 "RequestDate = @requestDate " +
                                 "where id = @id";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@email", editAccountRequest.Email);
                    cmd.Parameters.AddWithValue("@phone", editAccountRequest.PhoneNumber);

                    cmd.Parameters.AddWithValue("@street", editAccountRequest.Street);
                    cmd.Parameters.AddWithValue("@city", editAccountRequest.City);
                    cmd.Parameters.AddWithValue("@country", editAccountRequest.Country);

                    cmd.Parameters.AddWithValue("@postcode", editAccountRequest.Postcode);
                    cmd.Parameters.AddWithValue("@emConName", editAccountRequest.EmConName);
                    cmd.Parameters.AddWithValue("@emConRelation",
                        Convert.ToInt32(editAccountRequest.EmConRelation) + 1);
                    cmd.Parameters.AddWithValue("@emConEmail", editAccountRequest.EmConEmail);
                    cmd.Parameters.AddWithValue("@emConPhone", editAccountRequest.EmConPhone);

                    cmd.Parameters.AddWithValue("@status", editAccountRequest.Status);
                    cmd.Parameters.AddWithValue("@requestDate", editAccountRequest.RequestDate);

                    cmd.Parameters.AddWithValue("@id", editAccountRequest.Id);

                    conn.Open();

                    int effectedRows = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        
        // Holiday requests
        public IList<HolidayLeaveRequest> GetHLRs()
        {
            IList<HolidayLeaveRequest> hlrs = new List<HolidayLeaveRequest>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {

                    string sql = "SELECT * FROM holiday_leave_request";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    conn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        int id = Convert.ToInt32(dr[0]);
                        int empId = Convert.ToInt32(dr[1]);
                        DateTime startDay = (DateTime) dr[2];
                        DateTime endDay = (DateTime)dr[3];
                        int totalDays = Convert.ToInt32(dr[4]);
                        string status = dr[5].ToString();
                        string comments = dr[6].ToString();
                        DateTime requestDate = (DateTime) dr[7];
                        

                        HolidayLeaveRequest holidayLeaveRequest = new
                            HolidayLeaveRequest(id, empId, startDay, endDay, totalDays,
                                status, comments, requestDate);
                        hlrs.Add(holidayLeaveRequest);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return hlrs;
        }

        public void UpdateHLR(HolidayLeaveRequest holidayLeaveRequest)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {

                    string sql = "UPDATE  holiday_leave_request " +
                                 "set Status = @status " +
                                 "where id = @id";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@status", holidayLeaveRequest.Status);
                    cmd.Parameters.AddWithValue("@id", holidayLeaveRequest.Id);
                    
                    conn.Open();

                    int effectedRows = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public List<string> GetActivatedShortcuts(Employee emp)
        {
            try
            {
                int empId = emp.Id;
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {

                    string sql = "SELECT Name FROM shortcut WHERE empId = @empId";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@empId", empId);

                    conn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    List<string> shortcuts = new List<string>();

                    while (dr.Read())
                    {
                        string shortcut = dr[0].ToString();
                        shortcuts.Add(shortcut);
                    }

                    return shortcuts;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public void SaveShortcut(Employee employee, string shortcutName)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {

                    int empId = employee.Id;
                    string sql = "";


                    sql = "INSERT INTO shortcut (Name, empId)" +
                              "VALUES(@shortcutName, @empId)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@shortcutName", shortcutName);
                    cmd.Parameters.AddWithValue("@empId", empId);

                    conn.Open();

                    int effectedRows = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void RemoveShortcut(Employee employee, string shortcutName)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(this.ConnString))
                {
                    int empId = employee.Id;

                    string sql = "DELETE from shortcut WHERE empId = @empId AND Name = @shortcutName";


                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@empId", empId);
                    cmd.Parameters.AddWithValue("@shortcutName", shortcutName);

                    conn.Open();

                    int effectedRows = cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
    

}
