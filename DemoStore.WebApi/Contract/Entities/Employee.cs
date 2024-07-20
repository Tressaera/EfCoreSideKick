using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoStore.WebApi
{
    public partial class Employee
    {
        [Required]
        [Key]
        public int EmployeeId { get; set; }

        [StringLength(50)]
        public string? EmployeeName { get; set; }

        [StringLength(50)]
        public string? EmployeeSurname { get; set; }

        public decimal? EmployeeSalary { get; set; }

        [StringLength(50)]
        public string? EmployeeDepartment { get; set; }

        public bool? EmployeeStatus { get; set; }
    }
}
