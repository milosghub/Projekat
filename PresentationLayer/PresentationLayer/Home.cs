
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
        public Home(IUserBusiness _userBusiness)
        {
            this.userBusiness = _userBusiness ;
            InitializeComponent();
            textBoxPass.PasswordChar = '*';
            buttonLogIn.MouseEnter += OnMouseEnterButtonLogIn;
            buttonLogIn.MouseLeave += OnMouseLeaveButtonLogIn;
            buttonSignUp.MouseEnter += OnMouseEnterButtonSignUp;
            buttonSignUp.MouseLeave += OnMouseLeaveButtonSignUp;

        }

        private void OnMouseEnterButtonSignUp(object sender, EventArgs e)
        {
            buttonSignUp.BackColor = Color.White; // or Color.Red or whatever you want, SystemColors.ButtonHighlight
        }
        private void OnMouseLeaveButtonSignUp(object sender, EventArgs e)
        {
            buttonSignUp.BackColor = Color.DarkTurquoise;
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp form = new FormSignUp(userBusiness );
            form.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
           /* this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;*/
        }

        private void OnMouseEnterButtonLogIn(object sender, EventArgs e)
        {
            buttonLogIn.BackColor = Color.Yellow; // or Color.Red or whatever you want, SystemColors.ButtonHighlight
        }
        private void OnMouseLeaveButtonLogIn(object sender, EventArgs e)
        {
            buttonLogIn.BackColor = Color.Lime;
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
                    bill.ShowDialog();
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
                !string.IsNullOrEmpty(textBoxPass.Text))
            buttonLogIn.Enabled = true;
            else
                buttonLogIn.Enabled = false;

        }

        private void button1HelpHome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome! If you want to log in, you have to fill all fields. When it was done, the button Log in will be enabled. If you are new user, you can create a new account using the button Sign up.", "Instruction");

        }

        private void buttonExit2_Click(object sender, EventArgs e)
        {
            Home home = new Home(userBusiness);
            this.Close();
                    
        }
    }
}
