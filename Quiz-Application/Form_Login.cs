﻿using System;
using System.IO;
using System.Windows.Forms;

namespace Quiz_Application
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(path: "login.txt");
            {
                string line = string.Empty;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] loginArray = line.Split(' ');
                    if (textBox_user.Text.Equals(loginArray[0]) &&
                        textBox_password.Text.Equals(loginArray[1]))
                    {
                        Form_ChooseDomain f1 = new Form_ChooseDomain(loginArray[0]);
                        f1.Show();
                    }
                    else
                    {
                        if (textBox_user.Text.Equals("") && textBox_password.Text.Equals("") ||
                           textBox_user.Text.Equals("") || textBox_password.Text.Equals(""))
                        {
                            MessageBox.Show("Nu ați introdus username/parola sau ambele.", "Eroare");
                        }
                        else
                        {
                            MessageBox.Show("Ați introdus userul/parola greșit!" +
                            Environment.NewLine + "Mai încercați!", "Eroare");
                        }
                    }
                }
            }
        }
    }
}