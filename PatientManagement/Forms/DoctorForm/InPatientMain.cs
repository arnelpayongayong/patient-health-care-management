﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement.Forms.DoctorForm
{
    public partial class InPatientMain : MetroFramework.Forms.MetroForm
    {
        Classes.User currentUser = null;
        public InPatientMain(Classes.User user)
        {
            InitializeComponent();
            currentUser = user;
            label2.Text = "Dr ." + currentUser.firstname + " " + currentUser.lastname;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Forms.DoctorForm.AdmissionList(currentUser).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Forms.Laboratory.LaboratoryResultList().ShowDialog();
        }
    }
}
