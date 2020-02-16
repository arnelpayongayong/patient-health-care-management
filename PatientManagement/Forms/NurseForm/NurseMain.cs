﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement.Forms.NurseForm
{
    public partial class NurseMain : MetroFramework.Forms.MetroForm
    {
        public NurseMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form register = new Forms.PatientForm.RegisterPatient();

            register.ShowDialog();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form checkup = new Forms.PatientForm.CheckUPSearch();

            checkup.ShowDialog();
        }
    }
}
