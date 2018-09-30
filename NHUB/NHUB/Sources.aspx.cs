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
            Table tb = new Table();

            foreach(SourceProporties sp in li)
            {
                TableRow tr = new TableRow();
                tb.Rows.Add(tr);

                TableCell tc = new TableCell();
                tr.Cells.Add(tc);

                Label SNameLabel = new Label();
                PlaceHolder1.Controls.Add(SNameLabel);
                SNameLabel.Text = sp.SourceName;
                SNameLabel.Width = 200;



                HyperLink SourceDeleteHyperLink= new HyperLink();
                PlaceHolder1.Controls.Add(SourceDeleteHyperLink);             
                SourceDeleteHyperLink.Text = "Delete";                
                SourceDeleteHyperLink.NavigateUrl = "DeleteSource?Id="+sp.SourceId;
                SourceDeleteHyperLink.Width = 100;

                HyperLink SourceEditHyperLink = new HyperLink();
                PlaceHolder1.Controls.Add(SourceEditHyperLink);
                SourceEditHyperLink.Text = "Edit";
                SourceEditHyperLink.NavigateUrl = "EditSource?SName=" + sp.SourceName;
                SourceEditHyperLink.Width = 700;

                



            }
            

        }

        protected void SourceButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddSource.aspx");
        }
    }
}