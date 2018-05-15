<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeBehind="EditGirlFriend.aspx.cs" Inherits="ngoenGirlFriend.Admin.GirlFriend.EditGirlFriend" %>
<asp:Content ID="Content1" ContentPlaceHolderID="childContent" runat="server">
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
    <div class="container">
  <h2>Edit Girl Friend</h2>
        <asp:Label ID="lblThongbao" runat="server" Text="Label"></asp:Label>
    <div class="form-group">
      <label for="hoten">Họ tên:</label>
        <asp:TextBox ID="txtFullname" class="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
      <label for="phone">Số điện thoại:</label>
        <asp:TextBox ID="txtPhone" class="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
      <label for="email">Email:</label>
        <asp:TextBox ID="txtEmail" class="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="datepicker">Ngày sinh</label>
        <input type="text" id="datepicker" class="form-control" placeholder="Chọn ngày sinh" name="datepicker" value="<%=birthday %>" >
    </div>
    <div class="form-group">
        <label for="ghichu">Ghi chú</label>
        <asp:TextBox ID="txtGhiChu" name="ghichu" class="form-control" runat="server"></asp:TextBox> 
    </div>
    <div class="form-group">
    <label for="">Address</label>
            <div class="row">
                <div class="col-xs-3 col-md-3">
                    <asp:DropDownList ID="DropDownList1" AppendDataBoundItems="true" AutoPostBack="true" class="form-control" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    </asp:DropDownList>
                </div>
                <div class="col-xs-3 col-md-3">
                    <asp:DropDownList ID="DropDownList2" AppendDataBoundItems="true" AutoPostBack="true" class="form-control" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                    </asp:DropDownList>
                </div>
                <div class="col-xs-3 col-md-3">
                    <asp:DropDownList ID="DropDownList3" AppendDataBoundItems="true" AutoPostBack="true" class="form-control" runat="server">
                    </asp:DropDownList>
                </div>
            </div>
    </div>
    <div class="clearfix"></div>
    <div class="form-group  col-xs-6 col-md-6">
        <label>Hình ảnh</label>
    </div>
    <div class="clearfix"></div>
      <br />

    

    <div class="row">
            <div class="col-md-6">
                <div class="row">
                    <img id="profileImage" src="<%=sImageUrl %>" style="width:100%;height:250px;"/>
                </div>
                <div class="row">
                    <asp:FileUpload class="col-md-8" ID="FileUpload7" runat="server" />
                    <asp:Button class="btn btn-success col-md-3" ID="btnUpAnh" runat="server" Text="Đăng ảnh" OnClick="btnUpAnh_Click" />
                </div>
                
            </div>
            <div class="col-md-6">
                <div class="row">
                    <table class="table table-bordered">
                    <thead>
                      <tr>
                        <th>Hình ảnh</th>
                        <th>#</th>
                      </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater runat="server" ID="imageRepeater">
                                        <ItemTemplate>
                                            <tr>
                                              <td class="col-md-5 col-xs-5">
                                                 <img src="/Content/Image/<%#Eval("imageurl") %>" style="width:100%;height:100px;" onclick="imageClick(this)"/>
                                              </td>
                                              <td class="col-md-5 col-xs-5">
                                                <a class="btn btn-primary btn-xs" href="EditGirlFriend.aspx?id=<%#Eval("girlFriendID") %>&img=<%#Eval("imageId") %>"><span class="glyphicon glyphicon-trash"></span></a>
                                              </td>
                                            </tr>
                                        </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                  </table>
                    
                </div>
            </div>
        </div>
        <asp:Button ID="txtEdit" class="btn btn-success" runat="server" Text="Sửa" OnClick="txtEdit_Click"  />
</div>



    <script>
        $(function () {
            $("#datepicker").datepicker({
                dateFormat: 'mm/dd/yy',
                changeMonth: true,
                changeYear: true,
                yearRange: '-100y:c+nn',
                maxDate: '-1d'
            });
        });
        function imageClick(t) {
            var proimg = document.getElementById("profileImage");
            proimg.src = t.src;

        }
        
    </script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>

</asp:Content>
