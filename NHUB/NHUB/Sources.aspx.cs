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
    public partial class Sources : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SourceRepository sr = new SourceRepository();
            List<SourceProporties> li = new List<SourceProporties>();
            li = sr.SourceGetDetails();

        }

        protected void SourceButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddSource.aspx");
        }
    }
}