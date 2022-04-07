using System;
using System.Collections.Generic;
using System.Text;

namespace exp5.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string website { get; set; }

        Adress adress1 = new Adress();

        Company company1 = new Company();

    }
}
