<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="ManageProject.aspx.cs" Inherits="ManageProject" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="content" class="span10">
        <ul class="breadcrumb">
            <li><i class="icon-home"></i><a href="Home.aspx">Home</a> <i class="icon-angle-right">
            </i></li>
            <li><a href="#">Manage Projects</a></li>
        </ul>
        <div class="row-fluid sortable">
            <div class="box span12">
                <div class="box-header" data-original-title>
                    <h2>
                        <i class="halflings-icon user"></i><span class="break"></span>Projects</h2>
                    <div class="box-icon">
                        <a href="#" class="btn-setting"><i class="halflings-icon wrench"></i></a><a href="#"
                            class="btn-minimize"><i class="halflings-icon chevron-up"></i></a><a href="#" class="btn-close">
                                <i class="halflings-icon remove"></i></a>
                    </div>
                </div>
                <div class="box-content">
                    <table class="table table-striped table-bordered bootstrap-datatable datatable">
                        <thead>
                            <tr>
                                <th>
                                    Name
                                </th>
                                <th>
                                    Budget
                                </th>
                                <th>
                                    Start Time
                                </th>
                                <th>
                                    End Time
                                </th>
                                <th>
                                    Status
                                </th>
                                <th>
                                    Actions
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="Repeater1" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td>
                                            <%# Eval("Name") %>
                                        </td>
                                        <td class="center">
                                            <%# Eval("Budget") %>
                                        </td>
                                        <td class="center">
                                            <%# Convert.ToDateTime( Eval("ScheduledStartTime")).ToString("dd-MM-yyyy") %>
                                        </td>
                                        <td class="center">
                                            <%# Convert.ToDateTime( Eval("ScheduledEndTime")).ToString("dd-MM-yyyy") %>
                                        </td>
                                        <td class="center">
                                            <span class="label label-success">
                                                <%# Eval("Status") %></span>
                                        </td>
                                        <td class="center">
                                            <a class="btn btn-success" href="#"><i class="halflings-icon white zoom-in"></i>
                                            </a><a class="btn btn-info" href="#"><i class="halflings-icon white edit"></i></a>
                                            <a class="btn btn-danger" href="#"><i class="halflings-icon white trash"></i></a>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>
                </div>
            </div>
            <!--/span-->
        </div>
        <!--/row-->
    </div>
</asp:Content>
