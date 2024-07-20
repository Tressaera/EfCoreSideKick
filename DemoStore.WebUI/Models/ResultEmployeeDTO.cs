using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoStore.WebUI
{
    public class ResultEmployeeDTO
    {
        public int EmployeeId {get; set;}
        public string? EmployeeName {get; set;}
        public string? EmployeeSurname {get; set;}
        public decimal? EmployeeSalary {get; set;}
        public string? EmployeeDepartment {get; set;}
        public bool? EmployeeStatus {get; set;}
    }
}
