﻿using BusinessLayer;
using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormSignUp : Form
    {

        private readonly IUserBusiness userBusiness;
       // public readonly IUserBusiness __userBusiness;

        private string emailRegex = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

        public FormSignUp(IUserBusiness _userBusiness)
        {
            this.userBusiness = _userBusiness;
            InitializeComponent();
          //  this.userBusiness = __userBusiness;

        }

       // public FormSignUp()
      //  {

       // }



        private void FormSignUp_Load(object sender, EventArgs e)
        {
            // RefreshData();
            buttonSignUp.Enabled = false;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

 

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            // ValidationEmail();
           // DateTime temp;
            User u = new User();
            u.name = textBoxName.Text;
            u.surname = textBoxSurname.Text;
            u.username = textBoxUsername.Text;
            u.pass = textBoxPassword.Text;
            u.birth = Convert.ToDateTime(textBoxDateOfBirth.Text);
            // if (!DateTime.TryParse(textBoxDateOfBirth.Text, out temp))
            //  buttonSignUp.Enabled = false;
            //IsDateTime(textBoxDateOfBirth.Text);
                u.phone =textBoxPhoneNumber.Text;
            u.mail = textBoxEmail.Text;
            u.address = textBoxAddress.Text;
            bool result = this.userBusiness.Insert(u);
            if (result)
            {

                MessageBox.Show("Valid input!");
            }
            else
                MessageBox.Show("Invalid input!");
        }

      

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            ValidationSignUp();

        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {
            ValidationSignUp();

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            ValidationSignUp();

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            ValidationSignUp();

        }

        private void textBoxDateOfBirth_TextChanged(object sender, EventArgs e)
        {
            ValidationSignUp();

        }

        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            ValidationSignUp();

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            ValidationSignUp();

        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            ValidationSignUp();


        }
        private void ValidationSignUp()
        {
            if (!string.IsNullOrEmpty(textBoxName.Text) &&
                !string.IsNullOrEmpty(textBoxSurname.Text) && !string.IsNullOrEmpty(textBoxUsername.Text)
                && !string.IsNullOrEmpty(textBoxPassword.Text) && !string.IsNullOrEmpty(textBoxDateOfBirth.Text)
                && !string.IsNullOrEmpty(textBoxPhoneNumber.Text) && !string.IsNullOrEmpty(textBoxEmail.Text)
                && !string.IsNullOrEmpty(textBoxAddress.Text) && Regex.Match(textBoxEmail.Text, emailRegex).Success)
            {

                buttonSignUp.MouseEnter += new System.EventHandler(buttonSignUp_MouseEnter);
                buttonSignUp.Enabled = true;
            }
            else { 
                buttonSignUp.Enabled = false;
                buttonSignUp.MouseLeave += new System.EventHandler(buttonSignUp_MouseLeave);
            }

        }
      /*  public static bool IsDateTime(string txtDate)
        {
            DateTime tempDate;
            return DateTime.TryParse(txtDate, out tempDate);
        }*/

        

        private void labelHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome! All fields are required to create an account! Field birth of date has to be in the date format of your computer (examples: 03-jan-19, 2/2/2002, etc.). Field email must be in the following formats: example@test, example@test.com, example.e@test, example.e@test.com, etc. Phone number: only numbers!", "Instruction");
        }
        private void labelHelp_MouseEnter(object sender, EventArgs e)
        {
            labelHelp.BackColor = Color.Maroon;
            labelHelp.ForeColor = Color.White;

        }
        private void labelHelp_MouseLeave(object sender, EventArgs e)
        {
            labelHelp.BackColor = Color.Transparent;
            labelHelp.ForeColor = Color.Black;
        }
        private void buttonSignUp_MouseEnter(object sender, EventArgs e)
        {
            buttonSignUp.BackColor = Color.Blue;
            buttonSignUp.ForeColor = Color.White;

        }
        private void buttonSignUp_MouseLeave(object sender, EventArgs e)
        {
            buttonSignUp.BackColor = Color.DarkTurquoise;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*  private void ValidationEmail()
{
if (Regex.Match(textBoxEmail.Text, emailRegex).Success)
MessageBox.Show("Continue!");
else
MessageBox.Show("Invalid email!");
}*/




        /*  public void RefreshData()
{
listBox1.Items.Clear();
List<User> user = this.userBusiness.Get();
foreach(User u in user)
{
listBox1.Items.Add(u.name);
}

}*/

    }
}
