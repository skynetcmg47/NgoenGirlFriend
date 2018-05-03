<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ngoenGirlFriend._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <br /><br /><br /><br />
        <asp:Repeater runat="server" ID="girlRepeater">
            <ItemTemplate>
                <div class="col-md-4">
        
                    
                    <img src="Content/Image/moutant.jpg" style="height:200px; width:97%"/>
                    <h3><%#Eval("gFullName") %></h3>
                    <p>
                        <%#Eval("gNote") %>
                    </p>
                    <p>
                        <a class="btn btn-default" href="Detail.aspx?id=<%#Eval("girlFriendId") %>">Chi tiết</a>
                    </p>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

</asp:Content>
