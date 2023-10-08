﻿namespace EmployeeManagement.Shared
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int ManNumber { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}