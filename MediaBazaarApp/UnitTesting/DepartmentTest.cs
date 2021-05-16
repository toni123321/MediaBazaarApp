using MediaBazaarApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    /// <summary>
    /// Test department functionality
    /// </summary>
    [TestClass]
    public class DepartmentTest
    {
        private DepartmentManagement departmentManagement;
        public DepartmentTest()
        {
            departmentManagement = new DepartmentManagement();
        }


        [TestMethod]
        public void TestAddDepartment()
        {
            Assert.AreEqual(true, departmentManagement.AddDepartment("DepName"));
        }
    }
}
