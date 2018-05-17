using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ngoenGirlFriend.Account
{
    public partial class Changepassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bntChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["password"].ToString().Equals(txtPasswordOld.Text))
                {
                    Models.Account acc = new Models.Account();
                    acc.changepassword(txtNewPassword.Text, Session["userid"].ToString());
                    Response.Write("<script LANGUAGE='JavaScript' >alert('Thay đổi mật  khẩu thành công')</script>");
                    Response.Redirect("/Account/Account.aspx");
                }
                else
                {
                    Response.Write("<script LANGUAGE='JavaScript' >alert('Sai mật khẩu cũ')</script>");
                }
                
            }
            catch
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Thay đổi mật  khẩu không thành công')</script>");
            }
            
        }
    }
}