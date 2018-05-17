using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ngoenGirlFriend.Account
{
    public partial class Account : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadLoai();
            }
           
        }
        private void loadLoai()
        {
           
            lblID.Text = " ID của bạn: " + Session["userid"].ToString();
            Models.SqlConnection cn = new Models.SqlConnection();
            DataTable dt = new DataTable();

            string query = String.Format("SELECT fullname,email,phone,birthdate,uWardid,uDistrictid,uProvinceid FROM accountUser  WHERE  userid =" + "'" + Session["userid"].ToString() + "'");
            dt = cn.getData(query);
            foreach (DataRow item in dt.Rows)
            {
                txtFullnaem.Text = item["fullname"].ToString();
                txtPhone.Text = item["phone"].ToString();
                txtEmail.Text = item["email"].ToString();
                txtBirthdate1.Text = item["birthdate"].ToString();
                txtDistrictID.Text = item["uDistrictid"].ToString();
                txtWardID.Text = item["uWardid"].ToString();
                txtProvinceID.Text = item["uProvinceid"].ToString();
               
               
            }
          //  txtFullnaem.Text = "cc";
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBirthdate.Text == "")
                txtBirthdate.Text = txtBirthdate1.Text;
            try { 
            if (fulHinhdaidien.HasFile)
            {
                System.IO.FileInfo f = new System.IO.FileInfo(fulHinhdaidien.FileName);
                string newName = f.ToString();
                fulHinhdaidien.SaveAs(Server.MapPath("./") + "Hinh/" + newName);
                newName.ToString();
                Models.Account acc = new Models.Account();
                //var i = txtFullnaem.Text;
                acc.changeinfor(txtFullnaem.Text, txtPhone.Text, txtBirthdate.Text, newName, txtEmail.Text, txtWardID.Text, txtDistrictID.Text, txtProvinceID.Text, Session["userid"].ToString());
                loadLoai();
            }else {
                Models.Account acc = new Models.Account();
               // var i = txtFullnaem.Text;
                    acc.changeinfor1(txtFullnaem.Text, txtPhone.Text, txtBirthdate.Text, txtEmail.Text, txtWardID.Text, txtDistrictID.Text, txtProvinceID.Text, Session["userid"].ToString());
                loadLoai();
            }
                Response.Write("<script LANGUAGE='JavaScript' >alert('Cập nhật thông tin thành công')</script>");
            }
            catch
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Cập nhật thông tin thất bại')</script>");
            }





        }

        protected void btnchangepass_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Account/Changepassword.aspx");
        }
    }
}