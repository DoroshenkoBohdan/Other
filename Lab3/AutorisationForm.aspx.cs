using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab3
{
    public partial class AutorisationForm : System.Web.UI.Page
    {
        public Dictionary<string, string> admin = new Dictionary<string, string>
        {
            { "dorosh", "11111" },
            { "admin", "12345" }
        };

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Enter_Click(object sender, EventArgs e)
        {
            var userlogin = login.Text;
            var userpass = pass.Text;
            if (admin.Contains(new KeyValuePair<string, string>(userlogin, userpass)))
            {
                Session["user"] = userlogin;
                Response.Redirect("MainForm.aspx");
            }
        }
    }
}