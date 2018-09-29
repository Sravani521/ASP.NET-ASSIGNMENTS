using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SourceDAL.Model;
using SourceDAL.Repository;

namespace NHUB
{
    public partial class EditSource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Sources.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SourceRepository sr = new SourceRepository();
           // sr.EditSources(SName);
        }
    }
}