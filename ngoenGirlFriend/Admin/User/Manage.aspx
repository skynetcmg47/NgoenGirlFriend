<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="ngoenGirlFriend.Admin.User.Manage" %>
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
    <h3>User management</h3>
    
    <div class="panel panel-primary">
					<div class="panel-heading">
                        
						<a class="btn btn-primary btn-xs" style="border:hidden;" href="AddUser.aspx"><p style="font-size:20px">Add a new user</p></a>
                            
						<div class="pull-right" style="padding-top:20px">
                            <asp:TextBox ID="txtSearchString" name="txtSearch" runat="server"></asp:TextBox>
                            <a class="btn btn-primary btn-xs" href="Manage.aspx?search=<%=txtSearchString.Text%>"><span class="glyphicon glyphicon-search"></span></a>
						</div>
					</div>
					<table class="table table-hover">
						<thead>
							<tr>
								<th>ID</th>
                <th>Username</th>
                <th>Password</th>
                <th>Fullname</th>
                <th>Phone</th>
                <th>Image URL</th>
                <th>Email</th>
                <th>Role</th>
                <th>Ward</th>
                <th>District</th>
                <th>Province</th>                                                
                <th>Birthday</th>
                

							</tr>
						</thead>
						<tbody>
							<asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("userid") %></td>
                            <td><%#Eval("username") %></td>
                            <td><%#Eval("password") %></td>
                            <td><%#Eval("fullname") %></td>
                            <td><%#Eval("phone") %></td>
                            <td><%#Eval("imageurl") %></td>
                            <td><%#Eval("email") %></td>
                            <td><%#Eval("roleId") %></td>
                            <td><%#Eval("uWardid") %></td>
                            <td><%#Eval("uDistrictid") %></td>
                            <td><%#Eval("uProvinceid") %></td>
                            <td><%#Eval("birthdate") %></td>
                            <td></td>
                            
                            <td>
                                <a class="btn btn-primary btn-xs" href="./EditUser.aspx?id=<%#Eval("userid") %>"><span class="glyphicon glyphicon-pencil"></span></a>
                                <a class="btn btn-primary btn-xs" href="./Manage.aspx?id=<%#Eval("userid") %>"><span class="glyphicon glyphicon-trash"></span></a>
                                <a class="btn btn-primary btn-xs" href="./UserDetail.aspx?id=<%#Eval("userid") %>"><span class="glyphicon glyphicon-user"></span></a>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
						</tbody>
					</table>
				</div>
    
    
</asp:Content>