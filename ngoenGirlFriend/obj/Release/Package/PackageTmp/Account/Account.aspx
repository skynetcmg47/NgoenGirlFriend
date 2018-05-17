<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="ngoenGirlFriend.Account.Account" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="row" style="margin-top:100px">
        <div class="col-md-8 col-md-offset-3">
            <section id="Account" >
                <div class="form-horizontal" >
                    <h4>Thay đổi  thông tin.</h4>
                    <hr style="width:80%" align="left"/>
                    <div align="center" >
                        <asp:Label ID="lblID" runat="server" Text="Label"></asp:Label>
                    </div>
                     <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">Họ và tên: </asp:Label>
                         <div class="col-md-10">
                            <asp:TextBox ID="txtFullnaem" runat="server" CssClass="form-control"></asp:TextBox>
                             <asp:RequiredFieldValidator runat="server" ControlToValidate="txtFullnaem"
                                CssClass="text-danger" ErrorMessage="Vui lòng nhập Họ và tên." />
                         </div>
                     </div>
                     <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">Số Điện Thoại: </asp:Label>
                         <div class="col-md-10">
                            <asp:TextBox ID="txtPhone" runat="server" CssClass="form-control" TextMode="Phone"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" CssClass="text-danger" ErrorMessage="Vui lòng nhập đúng số  điện  thoại" ControlToValidate="txtPhone" ValidationExpression="(\+84|0)\d{9,10}"></asp:RegularExpressionValidator>
                           
                         </div>
                     </div>
                    <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">Birthdate: </asp:Label>
                         <div class="col-md-10">
                             <asp:TextBox ID="txtBirthdate1" runat="server"  CssClass="form-control" ReadOnly="True"></asp:TextBox>
                             <asp:TextBox ID="txtBirthdate" runat="server" CssClass="form-control" TextMode="Date" Width="280px"></asp:TextBox>
                         </div>
                     </div>
                   <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">Hình đại diện: </asp:Label>
                         <div class="col-md-10">
                             <asp:FileUpload ID="fulHinhdaidien" runat="server" CssClass="form-control" Width="280px" />
                         </div>
                     </div>
                    <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">Email: </asp:Label>
                         <div class="col-md-10">
                             <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
                         </div>
                     </div>
                    <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">Mã khu vực: </asp:Label>
                         <div class="col-md-10">
                             <asp:TextBox ID="txtWardID" runat="server" CssClass="form-control"></asp:TextBox>
                         </div>
                     </div>
                    <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">Mã Huyện: </asp:Label>
                         <div class="col-md-10">
                             <asp:TextBox ID="txtDistrictID" runat="server" CssClass="form-control"></asp:TextBox>
                         </div>
                     </div>
                    <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">Mã tỉnh: </asp:Label>
                         <div class="col-md-10">
                             <asp:TextBox ID="txtProvinceID" runat="server" CssClass="form-control"></asp:TextBox>
                         </div>
                     </div>
                    <div class="from-group"  align="center">
                         <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="btn btn-success" OnClick="btnUpdate_Click" />
                        
                    &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnchangepass" runat="server" Text="Đổi mật khẩu" CssClass="btn btn-success" OnClick="btnchangepass_Click" />
                    </div>
                          
            </section>
        </div>
    </div>
</asp:Content>
