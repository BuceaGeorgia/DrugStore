using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Repository;
namespace Tests
{
    [TestClass]
    public class RepoTests
    {
        [TestMethod]
        public void TestMethod1()
        {
         
            IUserRepository us = new UserRepository("test3");
           
            us.add("user", "user", Status.Pharmacist);
            User u = us.findOne("user", "user");
            Assert.AreEqual(u.Username, "user");
            us.delete("user", "user");
          

        }
        [TestMethod]
        public void TestMethod2()
        {
            ItemRepository ir = new ItemRepository("test3");
            OrderRepository or = new OrderRepository("test3");
            or.add(DateTime.Now);
           


        }
    }
}
