using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace WebApplication20.Models
{
    public class Employee
    {
        [Required (ErrorMessage = "Employee Id must")]
        [Display (Name = "Employee Id")]
        public int EmpId { get; set; }
        [Required(ErrorMessage = "Employee Name must")]
        [Display(Name = "Employee Name")]
        [MinLength(5,ErrorMessage ="Employee name must and should atleast 5 charecters")]
        [MaxLength(15, ErrorMessage = "Employee name cant be more than 15 charecters")]
        public string EmpName { get; set; }
        [Required(ErrorMessage = "Employee Salary must")]
        [Display(Name = "Employee Salary")]
        public int EmpSal { get; set; }

    }
}