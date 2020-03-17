using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeesInformation.Models
{
    public class Employees
    {
        [Key]
        [Required(ErrorMessage = "Please enter EmployeeID.")]
        public string EmployeeID { get; set; }
        [Required(ErrorMessage = "Please enter name.")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "Please enter department.")]
        public string Department { get; set; }
        [Required(ErrorMessage = "Please enter Salary.")]
        public double Salary { get; set; }
    }
}