<%@ Page Title="Mangage Girl Friend" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeBehind="ManageGirlFriend.aspx.cs" Inherits="ngoenGirlFriend.Admin.GirlFriend.ManageGirlFriend" %>
<asp:Content ID="Content1" ContentPlaceHolderID="childContent" runat="server">
    <style>
        .row{
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
        small-row{
           max-height: 100px !important;
           height: 100px !important;
        }
    </style>
        <a class="btn btn-info" href="AddGirlFriend.aspx">Add new GirlFriend</a>
            <br />
            <br />
        <div class="panel panel-primary">
					<div class="panel-heading">
						<h3 class="panel-title">Girl Friend</h3>
						<div class="pull-right">
                            <asp:TextBox ID="txtSearchString" ClientIDMode="Static" name="txtSearch" runat="server"></asp:TextBox>
                            <asp:Button ID="btnSearch" class="btn btn-success btn-xs" runat="server" Text="Search" OnClick="btnSearch_Click" />
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
                        <tr class="small-row">
                            <td><%#Eval("girlFriendID") %></td>
                            <td><%#Eval("gFullname") %></td>
                            <td><%#Eval("gPhone") %></td>
                            <td><%#Eval("gEmail") %></td>
                            <td><%#Eval("gBirthday") %></td>
                            <td><div style="overflow-y:scroll;"><%#Eval("gNote") %></div></td>
                            <td><%#Eval("gStatus") %></td>
                            <td><%#Eval("rating") %></td>
                            <td style="width:10%;">
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
