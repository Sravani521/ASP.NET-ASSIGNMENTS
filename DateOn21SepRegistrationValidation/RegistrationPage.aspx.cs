using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace DateOn21SepRegistrationValidation
{
    public partial class RegistrationPage : System.Web.UI.Page
    {
        //DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[2]{new DataColumn("Name"), new DataColumn("Country") });
                ViewState["value"] = dt;
                this.BindGrid();
            }
        }
        protected void BindGrid()
        {
            gvc.DataSource = (DataTable)ViewState["value"];
            gvc.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }


        protected void btnsubmit_Click(object sender, EventArgs e)
        {
          
            lb1.Items.Add(txtfname.Text);
            lb1.Items.Add(txtlname.Text);
            lb1.Items.Add(txtdob.Text);
            lb1.Items.Add(txtage.Text);
            lb1.Items.Add(txtnumber.Text);
            lb1.Items.Add(rdbgender.Text);
            lb1.Items.Add(ddlcountry.Text);

            DataTable dt = (DataTable)ViewState["value"];
            dt.Rows.Add(txtfname.Text.Trim(), txtlname.Text);
            ViewState["value"] = dt;
            this.BindGrid();

            //Attributes at = new Attributes();
            //at.fname = txtfname.Text;
            //at.lname = txtlname.Text;
            //at.dob = txtdob.Text;
            //at.gender = rdbgender.Text;
            //at.number = txtnumber.Text;
            //at.country = ddlcountry.Text;
            //Response.Write(txtfname.Text);
            // li.Add(at);
            ////foreach (object obj in li)
            //{
            //    Response.Write(obj);
            //    
            //}






        }

        protected void gvc_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        
    }


}
