﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class LaboratoryRequest
    {
        public int id { get; set; }
        public int doctorID { get; set; }
        public User user { get; set; }
        public Patient patient { get; set; }
        public int typeID { get; set; }
        public string type { get; set; }
        public string status { get; set; }
        public string urgency { get; set; }
        public string result { get; set; }
        public string isPaid { get; set; }
        public decimal price { get; set; }
        public DateTime date { get; set; }
        public List<TestType> testTypes { get; set; }
    }
}
