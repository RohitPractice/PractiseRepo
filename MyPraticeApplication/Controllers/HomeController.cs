using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using MyPraticeApplication.Models;

namespace MyPraticeApplication.Controllers
{
    public class HomeController : Controller
    {
            
        public ActionResult Index()
        {
            TempData["Id"] = 1;
            TempData["Name"] = "Rohit";
            TempData["Institue"] = "JDP";


            return View();
        }
        public ActionResult Student()
        {

            Student Obj = new Student()
            {
                Name = "Muhammad",
                Institute = "GCUF",
            };

            TempData["info"] = Obj;

            return View(Obj);
        }

        public ActionResult DisplayForMethod()
        {

            Student Obj = new Student()
            {
                Name = "Muhammad",
                Institute = "GCUF",
            };

            return View(Obj);
        }

        public ActionResult GetEmployeeData()
        {
            List<Employee> emp = new List<Employee>
            {
                new Employee
                {
                    EmployeeId = 1,
                    EmployeeName = "John",
                    Address = "12 Fremont St. Clermont, FL 2813",
                    Phone = "+1-234-2838421"
                },
                new Employee
                {
                    EmployeeId = 2,
                    EmployeeName = "Smith",
                    Address = "14 Highland Drive Fort Worth, TX 3994",
                    Phone = "+1-234-2244521"
                },
                new Employee
                {
                    EmployeeId = 3,
                    EmployeeName = "Marry",
                    Address = "23 Fremont Road Milledgeville, GA 6788",
                    Phone = "+1-234-46568421"
                }
            };

            TempData["employee"] = emp;

            return View();
        }

    }
}