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
    public partial class AddSource : System.Web.UI.Page
    {
        SourceRepository sr = new SourceRepository();
        List<SourceProporties> source = new List<SourceProporties>();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            sr.SourceGetDetails();
        }

        protected void CancelSourceButton_Click(object sender, EventArgs e)
        {
           
            Response.Redirect("Sources.aspx");
        }

        protected void CreateSourceButton_Click(object sender, EventArgs e)
        {

            
            string Name = NameTextBox.Text;

                if (Name == "")
                {
                    status.Text = "please fill the Name";
                }
                else
                {
                    sr.InsertSources(Name);
                    AddSuccessLabel.Text = "successfully created source";

                }
                       
                                            
        }
    }
}