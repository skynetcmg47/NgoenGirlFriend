<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="ngoenGirlFriend.Account.Signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row" style="margin-top:100px">
        <div class="col-md-8 col-md-offset-3">
           
                <div class="form-horizontal" >
                    <h4>Đăng ký</h4>
                    <hr style="width:80%" align="left"/>
                    
                    <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">Tên đăng nhập: </asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtUserName" CssClass="form-control"  />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtUserName"
                                CssClass="text-danger" ErrorMessage="Vui lòng nhập tên đăng nhập." />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">Mật khẩu</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword" CssClass="text-danger" ErrorMessage="Vui lòng nhập mật khẩu." />
                        </div>
                    </div>
         
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server" OnClick="LogIn" Text="Đăng Nhập" CssClass="btn btn-success" />
                        </div>
                    </div>
                </div>
                <p>
                    <asp:HyperLink CssClass="col-md-offset-2 col-md-10" runat="server" ID="RegisterHyperLink" ViewStateMode="Disabled">Đăng ký tài khoản mới</asp:HyperLink>
                </p>
                
            </section>
        </div>
    </div>
</asp:Content>
