using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using DAL.Repository;
using DAL.Model;


namespace Assignment
{
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Table dt = new Table();
            RepositoryFile rf = new RepositoryFile();
            List<ProductsInformation> li = new List<ProductsInformation>();
            li=rf.GetDetails();
            foreach (ProductsInformation pi in li)
            {
                TableRow tr = new TableRow();
                

                TableCell tc = new TableCell();

                Image img = new Image();
                img.ImageUrl = "~//" + pi.ImageUrl.ToString();
                img.Height = 100;
                img.Width = 100;

                HyperLink hl = new HyperLink();
                hl.NavigateUrl = "ProductDescription.aspx?id=" + pi.Id;
                hl.Text = pi.Name.ToString();

                tc.Controls.Add(img);
                tc.Controls.Add(hl);
                tr.Cells.Add(tc);

                dt.Rows.Add(tr);
                PlaceHolder1.Controls.Add(dt);
            }
          


           
           
        }
    }
}