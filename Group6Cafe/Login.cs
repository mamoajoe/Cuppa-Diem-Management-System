﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group6Cafe
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernamebox.Text == " " && passwordbox.Text == " ")
            {
                MessageBox.Show("Missing Information");
            }
            else if (usernamebox.Text == "Admin" && passwordbox.Text == "Password")
            {
                MessageBox.Show("Login Sucessfull");
                MainMenu obj = new MainMenu();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Enter the Correct Username and Password");
            }
        }

        private void usernamebox_TextChanged(object sender, EventArgs e)
        {

        }Z
    }
}
