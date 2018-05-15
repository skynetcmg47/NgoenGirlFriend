using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ngoenGirlFriend.Admin.GirlFriend
{
    public partial class ManageGirlFriend : System.Web.UI.Page
    {
        Models.GirlFriend gf = new Models.GirlFriend();

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
                if(Request.QueryString["id"] != null)
                {
                    try
                    {
                        gf.deleteGirl(int.Parse(Request.QueryString["id"].ToString()));
                        Response.Redirect("ManageGirlFriend.aspx");
                        Response.Write("<script>alert('Xoá thành công !')</script>");
                    }
                    catch (Exception)
                    {
                        Response.Redirect("ManageGirlFriend.aspx");
                        Response.Write("<script>alert('Xoá thất bại !')</script>");
                    }
                }
            if (Request.QueryString["search"] != null)
            {
                Repeater1.DataSource = gf.searchGirlFriends(Request.QueryString["search"]);
                Repeater1.DataBind();
            }
            else
            {
                Repeater1.DataSource = gf.getGirlFriends();
                Repeater1.DataBind();
            }

        }

    }
}