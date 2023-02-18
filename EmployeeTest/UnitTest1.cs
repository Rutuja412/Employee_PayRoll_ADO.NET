using EmployeePayroll_ADO.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace EmployeeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            EmployeeRepo repo = new EmployeeRepo();
            EmployeeModel employee = new EmployeeModel();
            employee.EmployeeName = "Madhura";
            employee.Department = "Technical";
            employee.PhoneNumber = "6302956565";
            employee.Address = "Chennai";
            employee.Gender = 'F';
            employee.BasicPay = 20000.00M;
            employee.Deductions = 2500.00;
            employee.StartDate = Convert.ToDateTime("2021-11-03");
            //Mock<EmployeeRepo> mockObj = new Mock<EmployeeRepo>();
            //mockObj.Setup(t=>t.AddEmployee(It.IsIn<EmployeeModel>)).return (true);
            var result = repo.AddEmployee(employee);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GetAllEmployeeShouldReturnListOfRecords()
        {
            EmployeeRepo repo = new EmployeeRepo();
            repo.GetAllEmployee();
            //Assert.IsTrue(result);
        }

    }
}
