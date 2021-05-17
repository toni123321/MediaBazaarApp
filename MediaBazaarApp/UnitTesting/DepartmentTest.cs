using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using MediaBazaarApp;

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
