using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDBDataAccessLayer.Models
{
    public class LinkModel
    {
        public int Id { get; set; }
        public string Linkname { get; set; }
        public string Linkurl { get; set; }

        public List<LinkModel> ToList()
        {
            throw new NotImplementedException();
        }
    }
}
