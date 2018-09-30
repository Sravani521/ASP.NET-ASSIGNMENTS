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
        string SName;        
        protected void Page_Load(object sender, EventArgs e)
        {
            SName = Request.QueryString["SName"];
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Sources.aspx");
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            SourceRepository sr = new SourceRepository();
            string Name = RenameTextBox.Text;
            if (Name == "")
            {
                status.Text = "please enter the name";
            }
            else
            {
                sr.EditSources(Name, SName);
                StatusLabel.Text = "rename success";
            }
        }
    }
}