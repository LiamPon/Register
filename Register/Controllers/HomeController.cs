using Register.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Register.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult RegistrationPage()
        {

            return View();
        }

        public ActionResult LoginPage()
        {

            return View();
        }

        public int validateUserFunc(string firstName, string lastName)
        {
            return 0;
        }

        public JsonResult postUser(RegistrationModel userInformation)
        {
            var fname = userInformation.firstName;
            var lname = userInformation.lastName;
            var address = userInformation.address;
            var phoneNumber = userInformation.phoneNumber;

            return Json(lname, JsonRequestBehavior.AllowGet);
        }

        public JsonResult loginUser(LoginModel userInformation)
        {
            return Json("Username: " + userInformation.username + ", Password: " + userInformation.password, JsonRequestBehavior.AllowGet);
        }

        public void AddEmployee(RegistrationModel empInfo)
        {
            try
            {
                var dateToday = DateTime.Now;
                using (var connect = new CompaniesContext())
                {
                    var newEmployee = new tblEmployeesModel()
                    {
                        fName = empInfo.firstName,
                        lName = empInfo.lastName,
                        address = empInfo.address,
                        deptID = 1,
                        posID = 1,
                        statID = 1,
                        createdAt = dateToday,
                        updatedAt = dateToday
                    };

                    connect.tblemployees.AddOrUpdate(newEmployee);
                    connect.SaveChanges();
                }
            }
            catch (Exception ex) 
            {
                var error = ex.Message;
            }
        }

        public void UpdateEmployee(RegistrationModel empInfo)
        {
            try
            {
                using (var connect = new CompaniesContext())
                {
                    var checkEmp = connect.tblemployees.Where(x => x.fName == empInfo.firstName && x.lName == empInfo.lastName).FirstOrDefault();
                    if (checkEmp == null)
                    {
                        AddEmployee(empInfo);
                    }
                    else
                    {
                        checkEmp.updatedAt = DateTime.Now;
                        connect.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                var error = ex.Message;
            }
        }
        public JsonResult LoadEmployees()
        {
            using(var db = new CompaniesContext())
            {
                var empdata = (from emp in db.tblemployees
                               join dept in db.tbldepartments on emp.deptID equals dept.deptID
                               where dept.isActive == 1
                               select new {emp, dept}).ToList();
                return Json(empdata, JsonRequestBehavior.AllowGet);
            }
        }
    }
}