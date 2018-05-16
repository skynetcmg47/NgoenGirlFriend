<%@ Page Title="Add Girl Friend" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeBehind="AddGirlFriend.aspx.cs" Inherits="ngoenGirlFriend.Admin.GirlFriend.AddGirlFriend" %>
<asp:Content ID="Content1" ContentPlaceHolderID="childContent" runat="server">
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
    <div class="container">
  <h2>Add Girl Friend</h2>
        <asp:Label ID="lblThongbao" runat="server" Text="Label"></asp:Label>
    <div class="form-group">
      <label for="hoten">Họ tên:</label>
        <asp:TextBox ID="txtFullname" class="form-control" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" Font-Bold="True" ForeColor="#FF3300" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txtFullname"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
      <label for="phone">Số điện thoại:</label>
        <asp:TextBox ID="txtPhone" class="form-control" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator runat=server 
            ControlToValidate="txtPhone" 
            ErrorMessage="Số điện thoại không đúng định dạng" 
            ValidationExpression="(09|01[2|6|8|9])+([0-9]{8})\b" Font-Bold="True" ForeColor="#FF3300" />
    </div>
    <div class="form-group">
      <label for="email">Email:</label>
        <asp:TextBox ID="txtEmail" class="form-control" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator runat=server 
            ControlToValidate="txtEmail" 
            ErrorMessage="Email phải có dạng abc@abc.abc" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Font-Bold="True" ForeColor="#FF3300"/>

    </div>
    <div class="form-group">
        <label for="datepicker">Ngày sinh</label>
        <asp:TextBox id="datepicker" class="form-control" name="datepicker" ClientIDMode="Static" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="ghichu">Ghi chú</label>
        <asp:TextBox ID="txtGhiChu" name="ghichu" class="form-control" runat="server" TextMode="MultiLine" Height="150px" ></asp:TextBox> 
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
        <asp:FileUpload class="form-control" ID="FileUpload1" runat="server" />
        <asp:FileUpload class="form-control" ID="FileUpload2" runat="server" />
        <asp:FileUpload class="form-control" ID="FileUpload3" runat="server" />
        <asp:FileUpload class="form-control" ID="FileUpload4" runat="server" />
        <asp:FileUpload class="form-control" ID="FileUpload5" runat="server" />
        <asp:FileUpload class="form-control" ID="FileUpload6" runat="server" />
    </div>
    <div class="clearfix"></div>
      <br />

    <asp:Button ID="txtAdd" class="btn btn-success" runat="server" Text="Thêm" OnClick="txtAdd_Click" />
        <a href="ManageGirlFriend.aspx" class="btn">Hủy bỏ</a>
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

        
    </script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>

</asp:Content>
