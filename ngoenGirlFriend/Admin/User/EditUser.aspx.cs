using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ngoenGirlFriend.Bean;

namespace ngoenGirlFriend.Admin.User
{
    public partial class EditUser : System.Web.UI.Page
    {
        Models.address address = new Models.address();
        Models.Account acc = new Models.Account();
        public string birthday;
        public string sImageUrl;
        public string imageBackup;
        
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
            if (!IsPostBack)
            {
                string id = Request.QueryString["id"];
                loadProvince();
                loadRole();
                if (id != null && id !="")
                {                  
                    DataTable dt = acc.getUserById(id);
                    if (dt.Rows.Count > 0)
                    {
                        if (dt.Rows[0]["uProvinceid"]!=null && dt.Rows[0]["uProvinceid"].ToString() != "")
                        {
                            loadDistrict(int.Parse(dt.Rows[0]["uProvinceid"].ToString()));
                            loadWard(int.Parse(dt.Rows[0]["uDistrictid"].ToString()));
                        }
                        
                        txtUsername.Text = dt.Rows[0]["username"].ToString();
                        txtPassword.Text = dt.Rows[0]["password"].ToString();
                        txtFullname.Text = dt.Rows[0]["fullname"].ToString();
                        txtPhone.Text = dt.Rows[0]["phone"].ToString();
                        txtEmail.Text = dt.Rows[0]["email"].ToString();
                        DropDownList4.SelectedValue = dt.Rows[0]["roleId"].ToString();
                        DropDownList3.SelectedValue = dt.Rows[0]["uWardid"].ToString();
                        DropDownList2.SelectedValue = dt.Rows[0]["uDistrictid"].ToString();
                        DropDownList1.SelectedValue = dt.Rows[0]["uProvinceid"].ToString();
                        sImageUrl = "/Content/Image/Account/" + dt.Rows[0]["imageurl"].ToString();
                        datepicker.Text = dt.Rows[0]["birthdate"].ToString();
                       
                    }
                    else
                    {
                        Response.Write("<script>alert('Invalid ID !')</script>");
                        
                    }
                }
                else
                {
                    Response.Write("<script>alert('ID is empty !')</script>");
                    
                }
            }
        }

        //load to dropdown list
        void loadProvince()
        {
            DropDownList1.DataSource = address.getProvince();
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("-- Chọn Tình/Thành phố --");
            DropDownList1.DataTextField = "name";
            DropDownList1.DataValueField = "provinceid";
            DropDownList1.DataBind();
        }
        void loadDistrict(int id)
        {
            DropDownList2.DataSource = address.getDistrictbyProvinceID(id);
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add("-- Chọn Quận/Huyện --");
            DropDownList2.DataTextField = "name";
            DropDownList2.DataValueField = "districtid";
            DropDownList2.DataBind();
        }

        void loadWard(int id)
        {
            DropDownList3.DataSource = address.getWardbyDistrictID(id);
            DropDownList3.Items.Clear();
            DropDownList3.Items.Add("-- Chọn Phường/Xã --");
            DropDownList3.DataTextField = "name";
            DropDownList3.DataValueField = "wardid";
            DropDownList3.DataBind();
        }

        void loadRole()
        {
            DropDownList4.DataSource = acc.getRole();
            DropDownList4.Items.Clear();
            DropDownList4.Items.Add("-- Chọn quyền hạn --");
            DropDownList4.DataTextField = "roleName";
            DropDownList4.DataValueField = "roleId";
            DropDownList4.DataBind();
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDistrict(int.Parse(DropDownList1.SelectedValue));
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadWard(int.Parse(DropDownList2.SelectedValue));
        }

        protected void Edit_Click(object sender, EventArgs e)
        {
            
                int id = int.Parse(Request.QueryString["id"]);
                DataTable dt = acc.getUserById(id+"");
                imageBackup = dt.Rows[0][5].ToString();
                int result = acc.updateUser(id, txtPassword.Text, txtFullname.Text, txtPhone.Text,
                            imageBackup, txtEmail.Text, int.Parse(DropDownList4.SelectedValue.ToString()),
                            int.Parse(DropDownList3.SelectedValue.ToString()), int.Parse(DropDownList2.SelectedValue.ToString()),
                            int.Parse(DropDownList1.SelectedValue.ToString()), String.Format("{0}", Request.Form["datepicker"]));

                if (result > 0)
                {
                    Response.Write("<script>alert('Success')</script>");
                    Response.Redirect("Manage.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Fail!')</script>");

                }
            
            

        }
        protected void Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Manage.aspx");
        }
    }
}