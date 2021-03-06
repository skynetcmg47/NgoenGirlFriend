﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ngoenGirlFriend.Bean;
using ngoenGirlFriend.Models;

namespace ngoenGirlFriend.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LogIn(object sender, EventArgs e)
        {
            
            Models.Account accountModel = new Models.Account();
            if (accountModel.checkLogin(txtUserName.Text, txtPassword.Text) != -1)
            {
                Bean.User userBean = accountModel.getUserSession();
                Session["fullName"] = userBean.FullName1;
                Session["userid"] = userBean.Userid;
                Session["userImageUrl"] = userBean.ImageUrl;
                Session["role"] = userBean.Role;
                Session["password"] = userBean.PassWord;
                if(userBean.Role == "1")
                    Response.Redirect("../Admin/GirlFriend/ManageGirlFriend.aspx");
                else
                    Response.Redirect("../Default.aspx");
            }
        }
    }
}