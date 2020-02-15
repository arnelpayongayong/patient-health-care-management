﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class Checkup
    {
        public string patientID { get; set; }
        public string temperature { get; set; }
        public string blood_pressure { get; set; }
        public string pulse_rate { get; set; }
        public TimeSpan time_arrived { get; set; }
        public int isTreated { get; set; }

        public Patient patient { get; set; }

    }
}