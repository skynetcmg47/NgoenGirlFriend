﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeBehind="UserDetail.aspx.cs" Inherits="ngoenGirlFriend.Admin.User.UserDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="childContent" runat="server">
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
    <div class="container">
  <h2>User detail</h2>
       
    <div class="form-group">
      <label for="username">Username:</label>
        <asp:TextBox ID="txtUsername" class="form-control" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
      <label for="password">Password:</label>
        <asp:TextBox ID="txtPassword" class="form-control" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword"
                                CssClass="text-danger" ErrorMessage="Please choose a password." />
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
    </div>
    <div class="form-group">
        <label for="datepicker">Birthdate</label>
        <input type="text" id="datepicker" class="form-control" placeholder="Chọn ngày sinh" name="datepicker" value="<%=birthday %>" >
    </div>
    <div class="form-group">
        <label for="roleId">Role:</label>
        <asp:DropDownList ID="DropDownList4" AppendDataBoundItems="true" AutoPostBack="true" class="form-control" runat="server">
                    </asp:DropDownList>
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
        <img id="profileImage" src="<%=sImageUrl %>" style="width:100%;height:250px;"/>
                
    </div>
    <div class="clearfix"></div>
      <br />

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
