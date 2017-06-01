using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vortragExample
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_redirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Contact.aspx");
     
        }
    }
}