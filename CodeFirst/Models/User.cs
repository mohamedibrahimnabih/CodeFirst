using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CodeFirst.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Img { get; set; }
        public DateTime DOB { get; set; }

        [NotMapped]
        public int Age => DateTime.Now.Year - DOB.Year;

        public List<Order> Orders { get; set; }
    }
}
