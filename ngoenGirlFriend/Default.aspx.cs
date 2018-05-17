using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ngoenGirlFriend.Models;
using System.Collections;
using System.Data;
namespace ngoenGirlFriend
{
    public partial class _Default : Page
    {
        
        string imageUrl;
        ArrayList girls;
        Models.GirlFriend girlModel = new Models.GirlFriend();

        protected void Page_Load(object sender, EventArgs e)
        {
            //girls = girlModel.getGirlFriends();
            if (!IsPostBack)
            {
                

                    string provinceid = Request.QueryString["provinceid"];
                    string search = Request.QueryString["search"];
                    if (provinceid != null && provinceid != "")
                    {
                        girlRepeater.DataSource = girlModel.getGirlFriendsByProvince(provinceid);
                        girlRepeater.DataBind();
                    }
                    else if (search != null && search != "")
                    {
                        girlRepeater.DataSource = girlModel.searchGirlFriend(search);
                        girlRepeater.DataBind();
                    }
                    else
                    {
                        DataTable dt = girlModel.getGirlFriends();
                        dt.Columns.Add("imageurl");
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            DataTable t_tb = girlModel.getGirlImage(dt.Rows[i]["girlFriendId"].ToString());
                        if (t_tb.Rows.Count > 0)
                            dt.Rows[i]["imageurl"] = t_tb.Rows[0]["imageurl"].ToString();
                        else
                            dt.Rows[i]["imageurl"] = "girl1.jpg";
                        }
                        girlRepeater.DataSource = dt;
                        girlRepeater.DataBind();
                    }
                
            }

            

            //TextBox1.Text = Session["userImageUrl"].ToString();
            //imageUrl = Session["userImageUrl"].ToString();
            //Image1.ImageUrl = "/Content/Image/" + imageUrl;
            

        }
    }
}