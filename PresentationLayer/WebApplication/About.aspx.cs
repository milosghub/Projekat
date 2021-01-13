using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class About : Page
    {

        private readonly IUserBusiness userBusiness;
        protected void Page_Load(object sender, EventArgs e)
        {
           // this.userBusiness = new IUserBusiness();
        }

        public About(IUserBusiness _userBusiness)
        {
            this.userBusiness = _userBusiness;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<User> list = this.userBusiness.Get();
           string username= TextBox1.Text;
            string password = TextBox2.Text;
            foreach (User u in list)
                if (u.username.Equals(username) && u.pass.Equals(password))
                {
                    ListBox1.Items.Add(u.userid + "--" + u.name + "--" + u.surname + "--" + u.username + "--" + u.pass + "--" + u.birth + "--" + u.phone + "--" + u.mail + "--" + u.address);
                    break;
                }
            
               

                
                
                }
    }
}