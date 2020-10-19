using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDBDataAccessLayer.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
    }
}
