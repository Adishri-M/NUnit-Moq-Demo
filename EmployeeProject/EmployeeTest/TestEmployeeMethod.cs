using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EmployeeProject;

namespace EmployeeTest
{
    [TestFixture]
    class TestEmployeeMethod
    {
        [Test]
        public void TestLogin()
        {
            EmployeeImpl emp = new EmployeeImpl();
            string x = emp.Login("Admin", "1234");
            string y = emp.Login("", "");
            string z = emp.Login("Admin", "Admin");
            Assert.AreEqual("Incorrect UserId or Password.", x);
            Assert.AreEqual("Userid or password could not be Empty.", y);
            Assert.AreEqual("Welcome Admin.", z);
        }

        List<Employee> li;
        [Test]
        public void CheckDetailsTest()
        {
            EmployeeImpl emp = new EmployeeImpl();
            li = emp.GetUsers();
            //Employee employee1 = new Employee();
            //employee1.Gender = null;
            //li.Add(employee1);
            
           
            foreach (var employee in li)
            {
                Assert.IsNotNull(employee.Id);
                Assert.IsNotNull(employee.Name);
                Assert.IsNotNull(employee.Gender);
                Assert.IsNotNull(employee.Salary);
            }

        }
        [Test]
        public void getuserdetails()
        {
            EmployeeImpl emp = new EmployeeImpl();
            Employee p = emp.getDetails(100).SingleOrDefault();
            Employee employee = p;
            //Employee employee = new Employee
            //{
            //    Id = 100,
            //    Name = "Bharat",
            //    Gender = "male",
            //    Salary = 40000
            //};
            Assert.AreSame(employee, p);
            // foreach (var x in p)
            {
                Assert.AreEqual(p.Id, 100);
                Assert.AreEqual(p.Name, "Bharat");
                //Assert.AreEqual(p.Id, employee.Id);
                //Assert.AreEqual(p.Name, employee.Name);
            }
        }
        [Test]
        public void CollectionTest()
        {
            EmployeeImpl emp = new EmployeeImpl();
            Employee emp1 = emp.getDetails(100).SingleOrDefault();
            Employee emp2 = emp.getDetails(101).SingleOrDefault();
            Employee employee = new Employee();
            List<Employee> mylist = new List<Employee> { emp1, emp2 };
            CollectionAssert.Contains(mylist, emp1);
            Assert.Contains(emp2, mylist);
           //Assert.Contains(employee, mylist);

        }
          
    }
}
