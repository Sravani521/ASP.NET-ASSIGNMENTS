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
    public partial class DeleteSource : System.Web.UI.Page
    {
        int SId;
        protected void Page_Load(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(Request.QueryString["Id"]);
            SId = Id;
            SourceRepository sr = new SourceRepository();
            List < SourceProporties > sp= sr.SourceGetDetails();

            foreach(SourceProporties s in sp)
            {
                if (s.SourceId == Id)
                {
                    Label1.Text = s.SourceName;

                }
            }

        }

        protected void DeleteSourceButton_Click(object sender, EventArgs e)
        {
            
            SourceRepository sr = new SourceRepository();
            Label DeleteSourceNameLabel = new Label();           
            sr.DeleteSources(SId);
            DeleteSourceLabel.Text = "deleted source";
                              
        }

        protected void CancelSourceButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Sources.aspx");
        }
    }
}