<%@ Page Title="Mangage Girl Friend" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeBehind="ManageGirlFriend.aspx.cs" Inherits="ngoenGirlFriend.Admin.GirlFriend.ManageGirlFriend" %>
<asp:Content ID="Content1" ContentPlaceHolderID="childContent" runat="server">
    <style>
        .row{
		    margin-top:40px;
		    padding: 0 10px;
		}
		.clickable{
		    cursor: pointer;   
		}

		.panel-heading div {
			margin-top: -18px;
			font-size: 15px;
		}
		.panel-heading div span{
			margin-left:5px;
		}
		.panel-body{
			display: none;
		}
    </style>

        <div class="panel panel-primary">
					<div class="panel-heading">
						<h3 class="panel-title">Girl Friend</h3>
						<div class="pull-right">
                            <asp:TextBox ID="txtSearchString" name="txtSearch" runat="server"></asp:TextBox>
                            <a class="btn btn-primary btn-xs" href="ManageGirlFriend.aspx?search=<%=txtSearchString.Text%>"><span class="glyphicon glyphicon-search"></span></a>
						</div>
					</div>
					<table class="table table-hover">
						<thead>
							<tr>
								<th>#</th>
                <th>Họ tên</th>
                <th>Số điện thoại</th>
                <th>Email</th>
                <th>Sinh nhật</th>
                <th>Ghi chú</th>
                <th>Trạng thái</th>
                <th>Đánh giá</th>
                <th>Hành động</th>
							</tr>
						</thead>
						<tbody>
							<asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("girlFriendID") %></td>
                            <td><%#Eval("gFullname") %></td>
                            <td><%#Eval("gPhone") %></td>
                            <td><%#Eval("gEmail") %></td>
                            <td><%#Eval("gBirthday") %></td>
                            <td><%#Eval("gNote") %></td>
                            <td><%#Eval("gStatus") %></td>
                            <td><%#Eval("rating") %></td>
                            <td>
                                <a class="btn btn-primary btn-xs" href="EditGirlFriend.aspx?id=<%#Eval("girlFriendID") %>"><span class="glyphicon glyphicon-pencil"></span></a>
                                <a class="btn btn-primary btn-xs" href="ManageGirlFriend.aspx?id=<%#Eval("girlFriendID") %>"><span class="glyphicon glyphicon-trash"></span></a>
                                <a class="btn btn-primary btn-xs" href="/GirlDetail.aspx?id=<%#Eval("girlFriendID") %>"><span class="glyphicon glyphicon-user"></span></a>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
						</tbody>
					</table>
				</div>


</asp:Content>
