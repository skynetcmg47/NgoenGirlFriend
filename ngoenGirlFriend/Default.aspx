<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ngoenGirlFriend._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div id="myCarousel" class="carousel slide" data-ride="carousel">
            <!-- Indicators -->
            <ol class="carousel-indicators">
                <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                <li data-target="#myCarousel" data-slide-to="1"></li>
                <li data-target="#myCarousel" data-slide-to="2"></li>
            </ol>

            <!-- Wrapper for slides -->
            <div class="carousel-inner">
                <div class="item active">
                    <img src="/Content/Image/girl1.jpg" style="height: 360px; width: 100%; z-index: 0;" alt="Los Angeles">
                </div>

                <div class="item">
                    <img src="/Content/Image/girl2.jpg" style="height: 360px; width: 100%; z-index: 0;" alt="Chicago">
                </div>

                <div class="item">
                    <img src="/Content/Image/d2.jpg" style="height: 360px; width: 100%; z-index: 0;" alt="New York">
                </div>
            </div>

            <!-- Left and right controls -->
            <a class="left carousel-control" href="#myCarousel" data-slide="prev">
                <span class="glyphicon glyphicon-chevron-left"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="right carousel-control" href="#myCarousel" data-slide="next">
                <span class="glyphicon glyphicon-chevron-right"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>
        <div class="row">
            <br />
            <br />
            <h4 class="text-center">Danh sách Idols</h4>
            <br />
            
            <asp:Repeater runat="server" ID="girlRepeater">
                <ItemTemplate>
                    <div class="col-md-4">


                        <img src="Content/Image/<%#Eval("imageurl") %>" style="height: 200px; width: 97%" />
                        <h3><%#Eval("gFullName") %></h3>
                        <p>Ngày sinh
                            <%#Eval("gBirthday") %>
                        </p>
                        <p>
                            <a class="btn btn-default" href="GirlDetail.aspx?id=<%#Eval("girlFriendId") %>">Chi tiết</a>
                        </p>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
