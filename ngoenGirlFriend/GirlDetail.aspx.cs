using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ngoenGirlFriend.Models;
using System.Data;

namespace ngoenGirlFriend
{
    public partial class GirlDetail : System.Web.UI.Page
    {
        public double rating;
        public int ratingAmount;
        public string fullname, imageurl;
        private string girlId;
        Models.GirlFriend girlModel = new Models.GirlFriend();
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
        public string sImageUrl;
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            girlId = id;
            DataTable dt = girlModel.getGirlFriend(id);
            DataTable imagedt = girlModel.getGirlImage(id);

            lbName.Text = dt.Rows[0]["gFullName"].ToString();
            lbgBirthday.Text = dt.Rows[0]["gBirthday"].ToString();
            gStatus.Text = dt.Rows[0]["gStatus"].ToString();
            sImageUrl = "/Content/Image/"+ imagedt.Rows[0]["imageurl"].ToString();
            gNote.Text = dt.Rows[0]["gNote"].ToString();

            rating = double.Parse(dt.Rows[0]["rating"].ToString());
            ratingAmount = int.Parse(dt.Rows[0]["ratingAmount"].ToString());

            imageRepeater.DataSource = imagedt;
            imageRepeater.DataBind();

            getUser();
            getComment(id);
        }

        private void getComment(string id)
        {
            DataTable dt = girlModel.getGirlComment(id);
            commentRepeater.DataSource = dt;
            commentRepeater.DataBind();
        }
        private void getUser()
        {
            //Models.Account accountModel = new Models.Account();
            //DataTable dt = accountModel.getUserById(id);
            fullname = Session["fullname"].ToString();
            imageurl = Session["userImageUrl"].ToString();
        }
        public void btnComment_Click(object sender, EventArgs e)
        {
            Models.Comment commentModel = new Comment();
           // try
           // {
                commentModel.leaveComment(Session["userid"].ToString(), girlId, txtComment.Text);
                txtComment.Text = "";
                Response.Redirect(Request.RawUrl);
          //  }
          //  catch(Exception ex)
          //  {
           //     Response.Redirect("Error.aspx");
           // }
            
        }

        public void btnRating_Click(object sender, EventArgs e)
        {
            Models.Rating ratingModel = new Rating();
            double newRating;
            if (ratingScore.SelectedValue.ToString() != "" && ratingScore.SelectedValue.ToString() != "0" && ratingScore.SelectedValue.ToString() != null)
            {
                newRating = (double)(rating * ratingAmount + int.Parse(ratingScore.SelectedValue.ToString())) / (ratingAmount + 1);
                ratingModel.leaveRating(Request.QueryString["id"], newRating+"", (ratingAmount + 1)+"");
            }




        }

    }
}