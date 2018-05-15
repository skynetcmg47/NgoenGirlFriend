using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ngoenGirlFriend.Admin.User
{
    public partial class Manage : System.Web.UI.Page
    {
        Models.Account acc = new Models.Account();
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            try
            {
                if (Page.Title.ToString() != "Login")
                {
                    string userid = Session["userid"].ToString();
                    if (userid == null || userid == "") Response.Redirect("/Account/Login.aspx");
                }

            }
            catch (Exception ex)
            {
                if (Page.Title.ToString() != "Login")
                    Response.Redirect("/Account/Login.aspx");
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {           
            string searchS = Request.QueryString["search"];
            if (Request.QueryString["id"] != null)
            {
                try
                {
                    if (acc.checkCommentByUser(int.Parse(Request.QueryString["id"].ToString())) == true)
                    {
                        acc.deleteCommentByUser(int.Parse(Request.QueryString["id"].ToString()));
                    }
                    acc.deleteUser(int.Parse(Request.QueryString["id"].ToString()));
                    Response.Write("<script>alert('Xoá thành công !')</script>");
                    Response.Redirect("Manage.aspx");
                    


                }
                catch (Exception)
                {
                    Response.Write("<script>alert('Xoá thất bại !')</script>");
                   
                }
            }
            else if (searchS != null && searchS!="")
            {

                Repeater1.DataSource = acc.searchUsers(searchS);
                Repeater1.DataBind();
            }
            else
            {
                Repeater1.DataSource = acc.getUsers();
                Repeater1.DataBind();
            }
            
        }
    }
}