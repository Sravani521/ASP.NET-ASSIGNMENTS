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
    public partial class Productupdate : System.Web.UI.Page
    {
        //SqlConnection con = null;
        //SqlCommand cmd = null;
        
       
        
        protected void Page_Load(object sender, EventArgs e)
        {
          if(!IsPostBack)
            {
                RepositoryFile rf = new RepositoryFile();
                int pid = Convert.ToInt32(Request.QueryString["Id"]);
                ProductsInformation pi = rf.GetDetail(pid);
                txtid.Text = pi.Id.ToString();
                txtname.Text = pi.Name.ToString();
                txtimage.Text = pi.ImageUrl.ToString();
                txtprice.Text = pi.Price.ToString();
                txtdesc.Text = pi.Description.ToString();

            }
                   
        }

        //public Productupdate()
        //{
        //    con = new SqlConnection("Data Source = ACUPC-0906; Initial Catalog = Assignment22sep; Integrated Security = True");
        //}

       

        protected void btnupdate_Click(object sender, EventArgs e)
        {

            RepositoryFile rf = new RepositoryFile();
            int id =Convert.ToInt32( txtid.Text);
            string name = txtname.Text;
            string img = txtimage.Text;
            double price = Convert.ToDouble(txtprice.Text);
            string desc = txtdesc.Text;
            int brandid = DropDownList1.SelectedIndex;
            rf.UpdateDetails(id,name, img, price, desc, brandid);

            lblupdate.Text = "updated successfully";          
                     
        }
    }
}

