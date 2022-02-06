using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace MyPraticeApplication.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string Institute { get; set; }
    }

    public class Employee
    {
        [Display(Name = "Serial No")]
        public byte EmployeeId { get; set; }

        [Display(Name = "Name")]
        public string EmployeeName { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }
    }
}