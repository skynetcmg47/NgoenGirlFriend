<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GirlDetail.aspx.cs" Inherits="ngoenGirlFriend.GirlDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <style>
        .checked {
            color: orange;
        }

        img {
            max-width: 100%;
            max-height: 100%;
        }

        .portrait {
            height: 80px;
            width: 30px;
        }

        .landscape {
            height: 30px;
            width: 80px;
        }

        .square {
            height: 75px;
            width: 75px;
        }

        img {
            border-radius: 8px;
        }
    </style>
    <br />
    <br />
    <br />
    <div class="container">
        <div class="row">
            <div class="col-md-5">
                <div class="row">
                    <asp:Image ID="profileImage" runat="server" />
                </div>
                <div class="row">
                </div>
            </div>
            <div class="col-md-7">
                <h3>
                    <asp:Label runat="server" ID="lbName"></asp:Label></h3>
                <%for (int i = 1; i <= 10; i++)
                    {
                        if (i <= rating)
                        {
                %>
                <span class="fa fa-star checked"></span>
                <%}
                    else
                    {%>
                <span class="fa fa-star"></span>
                <%}
                    }%> &nbsp;&nbsp;<%=ratingAmount %> votes



                <p>
                    Ngày sinh:
                    <asp:Label runat="server" ID="lbgBirthday"></asp:Label>
                </p>
                <br />
                <p>
                    Trạng thái:
                    <asp:Label runat="server" ID="gStatus"></asp:Label>
                </p>
            </div>
        </div>
        <div class="row">
            <br />
            <br />
            <ul class="nav nav-tabs">

                <li class="active"><a data-toggle="tab" href="#note">Giới thiệu</a></li>
                <li><a data-toggle="tab" href="#comment">Comment</a></li>

            </ul>

            <div class="tab-content">

                <div id="note" class="tab-pane fade in active">
                    <h3>Giới thiệu</h3>
                    <p>
                        <asp:Label runat="server" ID="gNote"></asp:Label>
                    </p>
                </div>
                <div id="comment" class="tab-pane fade">
                    <h3>Comment</h3>
                    <asp:Repeater runat="server" ID="commentRepeater">
                        <ItemTemplate>
                            <div class="row col-md-8 col-md-offset-1">
                                <div class="col-md-2">
                                    <img src="/Content/Image/Account/<%#Eval("imageurl") %>" style="width: 60%; height: 60%; border: 1px solid black;" />
                                </div>
                                <div class="col-md-10">
                                    <h4><%#Eval("fullname") %></h4>
                                    <p><%#Eval("commentContent") %></p>
                                </div>
                            </div>
                            <br />
                        </ItemTemplate>
                    </asp:Repeater>
                    <br />
                    <div class="row col-md-8 col-md-offset-1">
                        <hr />
                        <div class="col-md-2">
                            <img src="/Content/Image/Account/<%=imageurl %>" style="width: 60%; height: 60%; border: 1px solid black;" />
                        </div>
                        <div class="col-md-10">
                            <h4><%=fullname %></h4>
                            <asp:TextBox runat="server" ID="txtComment" CssClass="form-control" onkeypress="comment(event,this)" style="height:150px; "></asp:TextBox>
                            <asp:Button runat="server" ID="btnComment" Text="Comment" CssClass="btn btn-primary" OnClick="btnComment_Click"/>
                        </div>
                    </div>
                </div>

            </div>
        </div>

    </div>
    <script>
        function comment(e,t)
        {
            if(e.keyCode == 13)
            {
                document.getElementById("btnComment").click();
            }
        }
    </script>

</asp:Content>
