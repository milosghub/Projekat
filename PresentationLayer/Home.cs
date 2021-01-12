
using BusinessLayer;
using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Home : Form
    {
        private readonly IUserBusiness userBusiness;
       // private readonly IUserBusiness __userBusiness;
        public Home(IUserBusiness _userBusiness)
        {
            this.userBusiness = _userBusiness ;
            InitializeComponent();
            textBoxPass.PasswordChar = '*';
           // this.userBusiness = __userBusiness;
        }
        
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            /*EXCEPTION, BUT WORKS*/
            Home h = new Home(userBusiness);
            h.Close();
            FormSignUp form = new FormSignUp(userBusiness );
            form.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
           this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }

  
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPass.Text;
            List<User> users = this.userBusiness.Get();
            foreach(User u in users)
            {
                if (Equals(username, u.username) && Equals(password, u.pass))
                {
                    
                    Bill bill = new Bill();
                    bill.Show();
                    break;
                }
                else
                {
                    MessageBox.Show("Invalid values!!!");
                    break;
                }
            }    
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            ValidationLogIn();
        }

      
        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
            ValidationLogIn();
        }
        private void ValidationLogIn()
        {
            if (!string.IsNullOrEmpty(textBoxUsername.Text) &&
                !string.IsNullOrEmpty(textBoxPass.Text)) {
                buttonLogIn.Enabled = true;
                buttonLogIn.MouseEnter += new System.EventHandler(buttonLogIn_MouseEnter); }
            else { 
                buttonLogIn.Enabled = false;
                buttonLogIn.MouseLeave += new System.EventHandler(buttonLogIn_MouseLeave);
            
        }
        }

        private void labelHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome! If you want to log in, you have to fill all fields. When it was done, the button Log in will be enabled. If you are new user, you can create a new account using the button Sign up.", "Instruction");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void buttonLogIn_MouseEnter(object sender, EventArgs e)
        {
            buttonLogIn.BackColor = Color.Blue;
            buttonLogIn.ForeColor = Color.White;

        }
        private void buttonLogIn_MouseLeave(object sender, EventArgs e)
        {
            buttonLogIn.BackColor = Color.Lime;
        }
        private void labelHelp_MouseEnter(object sender, EventArgs e)
        {
            labelHelp.BackColor = Color.Maroon;
            labelHelp.ForeColor = Color.White;

        }
        private void labelHelp_MouseLeave(object sender, EventArgs e)
        {
            labelHelp.BackColor = Color.Transparent;
        }
    }
}
