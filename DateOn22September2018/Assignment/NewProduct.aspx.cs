using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Repository;

namespace Assignment
{
    public partial class NewProduct : System.Web.UI.Page
    {
       // SqlConnection con = null;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        //public NewProduct()
        //{
        //    con = new SqlConnection("Data Source = ACUPC-0906; Initial Catalog = Assignment22sep; Integrated Security = True");
        //}

        protected void btnadd_Click(object sender, EventArgs e)
        {

            RepositoryFile rf = new RepositoryFile();

            string name = txtname.Text;
            string img = txtimg.Text;
            double price =Convert.ToDouble( txtprice.Text);
            string desc = txtdesc.Text;
            int brandid = ddlid.SelectedIndex;
            rf.InsertDetails(name, img, price, desc, brandid);
            lbltxt.Text = "inserted successfully";

        }

        protected void ddl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}