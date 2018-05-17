<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="ngoenGirlFriend.Account.Signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
    <div class="container">
  <h2>Sign up</h2>
       
    <div class="form-group">
      <label for="username">Username:</label>
        <asp:TextBox ID="txtUsername" class="form-control" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="txtUsername" ErrorMessage="Please choose a username!" ID="RequireUserName" ForeColor="Red" />
    </div>

    <div class="form-group">
      <label for="password">Password:</label>
        <asp:TextBox ID="txtPassword" class="form-control" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword" ErrorMessage="Please choose a password!" ID="RequirePassword" ForeColor="Red" />
    </div>
    <div class="form-group">
      <label for="repassword">Re-enter password:</label>
        <asp:TextBox ID="txtRePassword" class="form-control" runat="server" TextMode="Password"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Must be same as password!" ControlToCompare="txtPassword" ControlToValidate="txtRePassword" ForeColor="Red"></asp:CompareValidator>
    </div>
    <div class="form-group">
      <label for="fullname">Fullname:</label>
        <asp:TextBox ID="txtFullname" class="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
      <label for="phone">Phone:</label>
        <asp:TextBox ID="txtPhone" class="form-control" runat="server"></asp:TextBox>
    </div>
   
    <div class="form-group">
      <label for="email">Email:</label>
        <asp:TextBox ID="txtEmail" class="form-control" runat="server"></asp:TextBox>
<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email is invalid!" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtEmail"></asp:RegularExpressionValidator>
    </div>
    <div class="form-group">
        <label for="datepicker">Birthdate</label>
        <input type="text" id="datepicker" class="form-control" placeholder="Chọn ngày sinh" name="datepicker">
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
        <label>Image</label>
        <asp:FileUpload class="form-control" ID="FileUpload1" runat="server" />
        
    </div>
    <div class="clearfix"></div>
      <br />

    <asp:Button ID="Register" class="btn btn-success" runat="server" Text="Register" OnClick="Register_Click" />
    <asp:Button ID="Cancel" class="btn" runat="server" Text="Cancel" OnClick="Cancel_Click" style="margin-left:40px" Width="100px"/>
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
