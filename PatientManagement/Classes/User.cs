﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Classes
{
    public class User
    {
        public string username {get;set;}
        public string password { get; set; }
        
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string position { get; set; }

        public bool isValid()
        {
            if(UserHelper.login(username, password) == 1)
            {
                return true;
            }

            return false;
        }
        
    }
}
