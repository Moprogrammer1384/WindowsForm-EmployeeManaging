using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Employeemanaging_Model.Entities
{
    public class EmployeesTB
    {
        [Key]
        
        public int Id { get; set; }
        public string  PersonalCode { get; set; }
        
        public string SecondSchoolCode { get; set; }
        public string FirstSchoolCode { get; set; }
        public string Position { get; set; }
        public string  Status { get; set; }
        public string  FirstSchool { get; set; }
        public string SecondSchool { get; set; }
        public string  Grade { get; set; }
        public string  LastName { get; set; }
        public string  FirstName { get; set; }
        public string  SchoolGender { get; set; }
        public string  Shift { get; set; }
        public string FatherName { get; set; }
        public string  Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string MainPhone { get; set; }
        public string NationaleCode { get; set; }
        public string AccountNumber { get; set; }
        public string Description { get; set; }

    }
}
