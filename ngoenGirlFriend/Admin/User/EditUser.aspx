<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeBehind="EditUser.aspx.cs" Inherits="ngoenGirlFriend.Admin.User.EditUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="childContent" runat="server">
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
    <div class="container">
  <h2>Edit user</h2>
       
    <div class="form-group">
      <label for="username">Username:</label>
        <asp:TextBox ID="txtUsername" class="form-control" runat="server" ReadOnly="True" ></asp:TextBox>
    </div>
    <div class="form-group">
      <label for="password">Password:</label>
        <asp:TextBox ID="txtPassword" class="form-control" runat="server"></asp:TextBox>
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
        <asp:TextBox id="datepicker" class="form-control" name="datepicker" ClientIDMode="Static" Text="<%=birthday %>" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="roleId">Role:</label>
        <asp:DropDownList ID="DropDownList4" AppendDataBoundItems="true" class="form-control" runat="server">
                    </asp:DropDownList>
    </div>
    <div class="form-group">
    <label for="">Address</label>
            <div class="row">
                <div class="col-xs-3 col-md-3">
                    <asp:DropDownList ID="DropDownList1" AppendDataBoundItems="true" class="form-control" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                    </asp:DropDownList>
                </div>
                <div class="col-xs-3 col-md-3">
                    <asp:DropDownList ID="DropDownList2" AppendDataBoundItems="true" class="form-control" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" AutoPostBack="True">
                    </asp:DropDownList>
                </div>
                <div class="col-xs-3 col-md-3">
                    <asp:DropDownList ID="DropDownList3" AppendDataBoundItems="true" class="form-control" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                </div>
            </div>
    </div>
    <div class="clearfix"></div>
    <div class="form-group  col-xs-6 col-md-6">
        <label>Image</label>
        <img id="profileImage" src="<%=sImageUrl %>" style="width:100%;height:250px;"/>
        <asp:FileUpload class="form-control" ID="FileUpload1" runat="server" />
        
    </div>
    <div class="clearfix"></div>
      <br />

    <asp:Button ID="Edit" class="btn btn-success" runat="server" Text="Edit" OnClick="Edit_Click" />
    <asp:Button ID="Cancel" class="btn" runat="server" Text="Cancel" OnClick="Cancel_Click" style="margin-left:40px"/>
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
