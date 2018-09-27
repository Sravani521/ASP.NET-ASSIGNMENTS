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
    public partial class ProductDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            RepositoryFile rf = new RepositoryFile();

            int id = Convert.ToInt32(txtid.Text);
            rf.DeleteDetails(id);
            lbldelete.Text = "Product Deleted Successfully";
        }



    }
}