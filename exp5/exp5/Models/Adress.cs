using System;
using System.Collections.Generic;
using System.Text;

namespace exp5.Models
{
    public class Adress
    {
        public string street { get; set; }
        public string suite { get; set; }
        public string city { get; set; }
        public string zipCode { get; set; }

        Geo geo1 = new Geo();
    }
}
