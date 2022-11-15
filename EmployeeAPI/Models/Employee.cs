﻿namespace EmployeeAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string? Email { get; set; }
    }
}
