using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDBDataAccessLayer.Models
{
    public class CompanyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LegalForm { get; set; }
        public int Address_Id { get; set; }
    }
}
