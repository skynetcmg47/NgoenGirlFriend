using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ngoenGirlFriend.Bean;
using System.Data;

namespace ngoenGirlFriend.Admin.GirlFriend
{
    public partial class AddGirlFriend : System.Web.UI.Page
    {
        Models.address ad = new Models.address();
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
            
            if (!IsPostBack)
            {
                loadProvince();

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

        List<string> getImageurl()
        {
            List<string> list = new List<string>();
            if (FileUpload1.FileName != "")
                list.Add(FileUpload1.FileName);
            if (FileUpload2.FileName != "")
                list.Add(FileUpload2.FileName);
            if (FileUpload3.FileName != "")
                list.Add(FileUpload3.FileName);
            if (FileUpload4.FileName != "")
                list.Add(FileUpload4.FileName);
            if (FileUpload5.FileName != "")
                list.Add(FileUpload5.FileName);
            if (FileUpload6.FileName != "")
                list.Add(FileUpload6.FileName);
            return list;
        }

        List<string> SaveImage(int gfid)
        {
            List<string> listurl = new List<string>();

            string newName;
            if (FileUpload1.FileName != "")
            {
                System.IO.FileInfo f = new System.IO.FileInfo(FileUpload1.FileName);
                newName = "Girl" + gfid + "-" + Guid.NewGuid().ToString("N") + f.Extension;
                FileUpload1.SaveAs(Server.MapPath("/") + "Content/Image/" + newName);
                listurl.Add(newName);
            }
            if (FileUpload2.FileName != "")
            {
                System.IO.FileInfo f = new System.IO.FileInfo(FileUpload2.FileName);
                newName = "Girl" + gfid + "-" + Guid.NewGuid().ToString("N") + f.Extension;
                FileUpload2.SaveAs(Server.MapPath("/") + "Content/Image/" + newName);
                listurl.Add(newName);
            }
            if (FileUpload3.FileName != "")
            {
                System.IO.FileInfo f = new System.IO.FileInfo(FileUpload3.FileName);
                newName = "Girl" + gfid + "-" + Guid.NewGuid().ToString("N") + f.Extension;
                FileUpload3.SaveAs(Server.MapPath("/") + "Content/Image/" + newName);
                listurl.Add(newName);
            }
            if (FileUpload4.FileName != "")
            {
                System.IO.FileInfo f = new System.IO.FileInfo(FileUpload4.FileName);
                newName = "Girl" + gfid + "-" + Guid.NewGuid().ToString("N") + f.Extension;
                FileUpload4.SaveAs(Server.MapPath("/") + "Content/Image/" + newName);
                listurl.Add(newName);
            }
            if (FileUpload5.FileName != "")
            {
                System.IO.FileInfo f = new System.IO.FileInfo(FileUpload5.FileName);
                newName = "Girl" + gfid + "-" + Guid.NewGuid().ToString("N") + f.Extension;
                FileUpload5.SaveAs(Server.MapPath("/") + "Content/Image/" + newName);
                listurl.Add(newName);
            }
            if (FileUpload6.FileName != "")
            {
                System.IO.FileInfo f = new System.IO.FileInfo(FileUpload6.FileName);
                newName = "Girl" + gfid + "-" + Guid.NewGuid().ToString("N") + f.Extension;
                FileUpload6.SaveAs(Server.MapPath("/") + "Content/Image/" + newName);
                listurl.Add(newName);
            }
            return listurl;
        }
        #endregion
        #region Events
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDistrict(int.Parse(DropDownList1.SelectedValue));
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadWard(int.Parse(DropDownList2.SelectedValue));
        }

        protected void txtAdd_Click(object sender, EventArgs e)
        {
            if(datepicker.Text == null || datepicker.Text == "")
            {
                lblThongbao.Text = "Vui lòng chọn ngày !";
                lblThongbao.ForeColor = System.Drawing.Color.Red;
            }
            else if (getImageurl().Count > 0)
            {
                try
                {
                    Models.ImageModels im = new Models.ImageModels();
                    int result = gf.insertGirlFriend(txtFullname.Text, int.Parse(DropDownList3.SelectedValue.ToString()), int.Parse(DropDownList2.SelectedValue.ToString()), int.Parse(DropDownList1.SelectedValue.ToString()), txtPhone.Text, txtEmail.Text, String.Format("{0}", Request.Form["datepicker"]), txtGhiChu.Text);


                    if (result > 0)
                    {
                        DataTable girl = gf.getTopGirl();
                        int gfid = int.Parse(girl.Rows[0]["girlFriendId"].ToString());
                        im.insertArrayImage(gfid, SaveImage(gfid));
                        lblThongbao.Text = "Thêm Girl Friend thành công !";
                        lblThongbao.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        lblThongbao.Text = "Thêm Girl Friend thất bại !";
                        lblThongbao.ForeColor = System.Drawing.Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    lblThongbao.Text = "Fail ! " + ex.Message;
                    lblThongbao.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                lblThongbao.Text = "Girl Friend phải có ít nhất 1 ảnh";
                lblThongbao.ForeColor = System.Drawing.Color.Red;
            }
        }

        #endregion



    }
}