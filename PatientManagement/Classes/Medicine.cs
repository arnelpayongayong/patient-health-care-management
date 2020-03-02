﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class Medicine
    {
        public int id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }

        public decimal price { get; set; }
    }
}
