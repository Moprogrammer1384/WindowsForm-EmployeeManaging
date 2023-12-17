using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Employeemanaging_Model.Entities
{
    public class Login
    {
        [Key]
        public int id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
