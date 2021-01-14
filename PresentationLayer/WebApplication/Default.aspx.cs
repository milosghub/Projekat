using BusinessLayer;
using Shared.Interfaces.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class _Default : Page
    {
        private  IUserBusiness userBusiness;

        public _Default(IUserBusiness _userBusiness)
        {
            this.userBusiness =_userBusiness;

        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}