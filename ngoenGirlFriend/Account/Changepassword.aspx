<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Changepassword.aspx.cs" Inherits="ngoenGirlFriend.Account.Changepassword" %>

<script runat="server">

  
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="row" style="margin-top:100px">
        <div class="col-md-8 col-md-offset-3">
            <section id="Changepassword" >
                <div class="form-horizontal" >
                    <h4>Thay đổi mật khẩu.</h4>
                    <hr style="width:80%" align="left"/>
                    <div align="left">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Account/Account.aspx">Quay lại</asp:HyperLink>
                    </div>
                     <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">Mật Khẩu hiện tại: </asp:Label>
                         <div class="col-md-10">
                             <asp:TextBox ID="txtPasswordOld"  CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPasswordOld"
                                CssClass="text-danger" ErrorMessage="Vui lòng nhập mật khẩu hiện tại." />
                         </div>
                     </div>
                     <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">Mật khẩu mới: </asp:Label>
                         <div class="col-md-10">
                             <asp:TextBox ID="txtNewPassword" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
                              <asp:RequiredFieldValidator runat="server" ControlToValidate="txtNewPassword"
                                CssClass="text-danger" ErrorMessage="Vui lòng nhập mật khẩu mới." />
                         </div>
                     </div>
                    <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">Nhập lại mật  khẩu mới: </asp:Label>
                         <div class="col-md-10">
                             <asp:TextBox ID="txtNewPasswordAgain" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
                             <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Mật khẩu  không giống nhau" ControlToCompare="txtNewPassword" ControlToValidate="txtNewPasswordAgain" CssClass="text-danger"></asp:CompareValidator>
                             <asp:RequiredFieldValidator runat="server" ControlToValidate="txtNewPasswordAgain"
                                CssClass="text-danger" ErrorMessage="Vui lòng nhập mật khẩu mới." />
                         </div>
                     </div>
                    <div class="from-group"  align="center">
                        <asp:Button ID="bntChangePassword" runat="server" Text="Thay đổi mật khẩu" CssClass="btn btn-success" OnClick="bntChangePassword_Click" />

                    </div>
                    </div>
                </section>
            </div>
         </div>
</asp:Content>
