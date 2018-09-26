using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Repository;
using DAL.Model;

namespace Assignment
{
    public partial class ProductDescription : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RepositoryFile rf = new RepositoryFile();
            List<ProductsInformation> li = new List<ProductsInformation>();
            li = rf.GetDetails();
            int pid = Convert.ToInt32(Request.QueryString["id"]);

            foreach (ProductsInformation obj in li)
            {
                if (pid == obj.Id)
                {
                  ProductName.Text = obj.Name.ToString();
                  ProductPrice.Text = obj.Price.ToString();
                  ProductImage.ImageUrl = obj.ImageUrl.ToString();
                  ProductsDescription.Text = obj.Description.ToString();
                }
            }
        }
    }
}