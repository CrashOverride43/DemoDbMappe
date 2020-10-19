using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDBDataAccessLayer.Models
{
    public class AddressModel
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
    }
}
