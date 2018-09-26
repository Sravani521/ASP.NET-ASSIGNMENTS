using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Repository;

namespace Assignment
{
    public partial class Productmanagement: Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Table dt = new Table();
            RepositoryFile rf = new RepositoryFile();
            List<ProductsInformation> li = new List<ProductsInformation>();
            li = rf.GetDetails();
            foreach (ProductsInformation pi in li)
            {
                TableRow tr = new TableRow();
                dt.Rows.Add(tr);

                TableCell tc = new TableCell();
                tr.Cells.Add(tc);
                Image img = new Image();
                PlaceHolder1.Controls.Add(img);
                img.ImageUrl = "~//" + pi.ImageUrl.ToString();
                img.Height = 100;
                img.Width = 100;

                HyperLink HlPreview = new HyperLink();
                PlaceHolder1.Controls.Add(HlPreview);
                HlPreview.NavigateUrl = "ProductDescription?id=" + pi.Id;
                HlPreview.Text = "Preview";

                HyperLink HlUpdate = new HyperLink();
                PlaceHolder1.Controls.Add(HlUpdate);
                HlUpdate.NavigateUrl = "ProductDescription?id=" + pi.Id;
                HlUpdate.Text = "Update";

                HyperLink HlDelete = new HyperLink();
                PlaceHolder1.Controls.Add(HlDelete);
                HlDelete.NavigateUrl = "ProductDescription?id=" + pi.Id;
                HlDelete.Text = "Delete";
              
              

            }
        }
        

        public void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductDescription.aspx");
        }
    }
}