using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ngoenGirlFriend.Models;
using System.Collections;
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
            girlRepeater.DataSource = girlModel.getGirlFriends();
            girlRepeater.DataBind();

            

            //TextBox1.Text = Session["userImageUrl"].ToString();
            //imageUrl = Session["userImageUrl"].ToString();
            //Image1.ImageUrl = "/Content/Image/" + imageUrl;
            

        }
    }
}