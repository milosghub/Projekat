using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Drawing;

namespace WebApplication
{
    public partial class Start : System.Web.UI.Page
    {
        private  IUserBusiness userBusiness;

        private string emailRegex = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

        public Start(IUserBusiness _userBusiness)
        {
            this.userBusiness = _userBusiness;

        }


        protected void Page_Load(object sender, EventArgs e)
        {
           // ButtonSignUp.Enabled = false;

        }

 
        public void MsgBox(String ex, Page pg, Object obj)
        {
            string s="<SCRIPT language='javascript'>alert('"+ex.Replace("\r\n","\\n").Replace("'","")+"');</SCRIPT>";
            Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }

        
        private void ValidationSignUp2()
        {
            if (!string.IsNullOrEmpty(TextBoxName.Text) && !string.IsNullOrEmpty(TextBoxSurname.Text) && !string.IsNullOrEmpty(TextBoxUsername.Text)
                           && !string.IsNullOrEmpty(TextBoxPassword.Text) && !string.IsNullOrEmpty(TextBoxDateOfBirth.Text)
                           && !string.IsNullOrEmpty(TextBoxPhoneNumber.Text) && !string.IsNullOrEmpty(TextBoxEmail.Text)
                           && !string.IsNullOrEmpty(TextBoxAddress.Text) && Regex.Match(TextBoxEmail.Text, emailRegex).Success)
            // ButtonSignUp.Enabled = true;
             ButtonSignUp.Enabled = true;

            else
                ButtonSignUp.Enabled = false;
         /*   ButtonSignUp.Enabled = (!string.IsNullOrWhiteSpace(TextBoxName.Text) && !string.IsNullOrWhiteSpace(TextBoxSurname.Text)
              && !string.IsNullOrWhiteSpace(TextBoxUsername.Text) && !string.IsNullOrWhiteSpace(TextBoxPassword.Text)
              && !string.IsNullOrWhiteSpace(TextBoxDateOfBirth.Text) && !string.IsNullOrWhiteSpace(TextBoxPhoneNumber.Text)
              && !string.IsNullOrWhiteSpace(TextBoxPhoneNumber.Text) && !string.IsNullOrWhiteSpace(TextBoxAddress.Text)
              && !string.IsNullOrWhiteSpace(TextBoxEmail.Text)) ;*/

        }


        protected void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            ValidationSignUp2();

        }

        protected void TextBoxSurname_TextChanged(object sender, EventArgs e)
        {
            ValidationSignUp2();

        }
        protected void TextBoxUsername_TextChanged(object sender, EventArgs e)
        {
            ValidationSignUp2();

        }


        protected void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            ValidationSignUp2();

        }

        protected void TextBoxDateOfBirth_TextChanged(object sender, EventArgs e)
        {
            ValidationSignUp2();

        }

        protected void TextBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            ValidationSignUp2();

        }

        protected void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            ValidationSignUp2();

        }

        protected void TextBoxAddress_TextChanged(object sender, EventArgs e)
        {
            ValidationSignUp2();

        }

        protected void ButtonSignUp_Click(object sender, EventArgs e)
        {
            User u = new User();
              u.name = TextBoxName.Text;
           // string name;
           // u.name=((TextBox)TextBoxName.FindControl("TextBoxName")).Text;

            u.surname = TextBoxSurname.Text;
          // u.surname= ((TextBox)TextBoxSurname.FindControl("TextBoxSurname")).Text;
            u.username = TextBoxUsername.Text;
            u.pass = TextBoxPassword.Text;
            u.birth = Convert.ToDateTime(TextBoxDateOfBirth.Text);
         //  u.username= ((TextBox)TextBoxUsername.FindControl("TextBoxUsername")).Text;
        //  u.pass=  ((TextBox)TextBoxPassword.FindControl("TextBoxPassword")).Text;
        //   u.birth=Convert.ToDateTime( ((TextBox)TextBoxDateOfBirth.FindControl("TextBoxDateOfBirth")).Text);
            // if (!DateTime.TryParse(textBoxDateOfBirth.Text, out temp))
            //  buttonSignUp.Enabled = false;
            //IsDateTime(textBoxDateOfBirth.Text);


            u.phone = TextBoxPhoneNumber.Text;
            u.mail = TextBoxEmail.Text;
            u.address = TextBoxAddress.Text;
        //  u.phone= ((TextBox)TextBoxPhoneNumber.FindControl("TextBoxPhoneNumber")).Text;
        //   u.mail= ((TextBox)TextBoxEmail.FindControl("TextBoxEmail")).Text;
         //   u.address= ((TextBox)TextBoxAddress.FindControl("TextBoxAddress")).Text;
            bool result = this.userBusiness.Insert(u);
            if (result)
            {
                //ListBoxShow.Items.Add(u.name + "\n" + u.surname + "---\n" + u.username+"---\n"+u.pass+"--\n-"+u.birth+"--\n-"+u.phone+"-\n--"+u.mail+"-\n--"+u.address);
                //MsgBox("Valid input!",this.Page,this);
                ListBoxShow.Items.Add("Valid input!");

            }
            else
                ListBoxShow.Items.Add("Invalid input!");

            // MsgBox("Invalid input!", this.Page, this);
            

        }

    }
}