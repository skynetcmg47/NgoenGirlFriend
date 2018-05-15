using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ngoenGirlFriend.Admin.GirlFriend
{
    public partial class EditGirlFriend : System.Web.UI.Page
    {
        Models.address ad = new Models.address();
        Models.GirlFriend gf = new Models.GirlFriend();
        Models.ImageModels im = new Models.ImageModels();

        public string birthday;
        public string sImageUrl;

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
                string imageid = Request.QueryString["img"];
                if (id != null)
                {
                    if(imageid != null)
                    {
                        im.deleteImagebyimgId(int.Parse(imageid));
                        Response.Redirect("EditGirlFriend.aspx?id="+id);
                            
                    }
                    int girlid = int.Parse(id);
                    loadProvince();
                    DataTable dt = gf.getGirlbyID(girlid);
                    if(dt.Rows.Count > 0)
                    {
                        loadDistrict(girlid);
                        loadWard(int.Parse(dt.Rows[0]["gDistrictid"].ToString()));

                        txtFullname.Text = dt.Rows[0]["gFullName"].ToString();
                        DropDownList3.SelectedValue = dt.Rows[0]["gWardid"].ToString();
                        DropDownList2.SelectedValue = dt.Rows[0]["gDistrictid"].ToString();
                        DropDownList1.SelectedValue = dt.Rows[0]["gProvince"].ToString();
                        txtPhone.Text = dt.Rows[0]["gPhone"].ToString();
                        txtEmail.Text = dt.Rows[0]["gEmail"].ToString();
                        txtGhiChu.Text = dt.Rows[0]["gNote"].ToString();
                        birthday = dt.Rows[0]["gBirthday"].ToString();

                        DataTable listImage = im.getImagebyGFId(girlid);

                        sImageUrl = "/Content/Image/" + listImage.Rows[0]["imageurl"].ToString();
                        imageRepeater.DataSource = listImage;
                        imageRepeater.DataBind();
                    }
                    else
                    {
                        Response.Write("ID Không hợp lệ !");
                        lblThongbao.Text = "Fail ! ";
                        lblThongbao.ForeColor = System.Drawing.Color.Red;
                    }
                       

                }
                else
                {
                    Response.Write("Chưa có ID !");
                    lblThongbao.Text = "Chưa có ID " ;
                    lblThongbao.ForeColor = System.Drawing.Color.Red;
                }


            }
        }

        #region Methods

        void loadDistrict(int id)
        {
            DropDownList2.DataSource = ad.getDistrictbyProvinceID(id);
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add("-- Chọn Quận/Huyện --");
            DropDownList2.DataTextField = "name";
            DropDownList2.DataValueField = "districtid";
            DropDownList2.DataBind();
        }

        void loadWard(int id)
        {
            DropDownList3.DataSource = ad.getWardbyDistrictID(id);
            DropDownList3.Items.Clear();
            DropDownList3.Items.Add("-- Chọn Phường/Xã --");
            DropDownList3.DataTextField = "name";
            DropDownList3.DataValueField = "wardid";
            DropDownList3.DataBind();
        }

        void loadProvince()
        {
            DropDownList1.DataSource = ad.getProvince();
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("-- Chọn Tình/Thành phố --");
            DropDownList1.DataTextField = "name";
            DropDownList1.DataValueField = "provinceid";
            DropDownList1.DataBind();
        }

        
        #endregion

        #region Events
        protected void txtEdit_Click(object sender, EventArgs e)
        {
                try
                {
                    int girlid = gf.getGirlID(txtFullname.Text,txtPhone.Text, txtEmail.Text);
                    int result = gf.updateGirlFriend(girlid,txtFullname.Text, int.Parse(DropDownList3.SelectedValue.ToString()), int.Parse(DropDownList2.SelectedValue.ToString()), int.Parse(DropDownList1.SelectedValue.ToString()), txtPhone.Text, txtEmail.Text, String.Format("{0}", Request.Form["datepicker"]), txtGhiChu.Text);

                    if (result > 0)
                    {
                        lblThongbao.Text = "Sửa Girl Friend thành công !";
                        lblThongbao.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        lblThongbao.Text = "Sửa Girl Friend thất bại !";
                        lblThongbao.ForeColor = System.Drawing.Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    lblThongbao.Text = "Fail ! " + ex.Message;
                    lblThongbao.ForeColor = System.Drawing.Color.Red;
                }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDistrict(int.Parse(DropDownList1.SelectedValue));
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadWard(int.Parse(DropDownList2.SelectedValue));
        }


        #endregion

        protected void btnUpAnh_Click(object sender, EventArgs e)
        {
            string newName;
            int girlid = int.Parse(Request.QueryString["id"]);
            if (FileUpload7.FileName != "")
            {
                System.IO.FileInfo f = new System.IO.FileInfo(FileUpload7.FileName);
                newName = "Girl" + girlid + "-" + Guid.NewGuid().ToString("N") + f.Extension;
                FileUpload7.SaveAs(Server.MapPath("/") + "Content/Image/" + newName);
                im.insert(girlid, newName);
            }
            Response.Redirect("EditGirlFriend.aspx?id="+girlid);
        }
    }
}