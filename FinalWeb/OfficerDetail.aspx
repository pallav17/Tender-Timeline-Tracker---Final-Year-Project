<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OfficerDetail.aspx.cs" Inherits="OfficerDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   <!-- start: Content -->
    <div id="content" class="span10">
        <ul class="breadcrumb">
            <li><i class="icon-home"></i><a href="OfficerDetail.aspx">Home</a> <i class="icon-angle-right">
            </i></li>
            <li><i class="icon-edit"></i><a href="#">Officer Detail</a> </li>
        </ul>
        <div class="row-fluid sortable">
            <div class="box span12">
                <div class="box-header" data-original-title>
                    <h2>
                        <i class="halflings-icon edit"></i><span class="break"></span>Officer Details</h2>
                    <div class="box-icon">
                        <a href="#" class="btn-setting"><i class="halflings-icon wrench"></i></a><a href="#"
                            class="btn-minimize"><i class="halflings-icon chevron-up"></i></a><a href="#" class="btn-close">
                                <i class="halflings-icon remove"></i></a>
                    </div>
                </div>
                <div class="box-content">
                    <div class="form-horizontal">
                        <fieldset>
                            <div class="control-group">
                                <label class="control-label" for="focusedInput">
                                    Officer Name</label>
                                <div class="controls">
                                    <asp:TextBox ID="txtName" runat="server" class="input-xlarge" />
                                    </div>
                            </div>


       


                            <div class="control-group">
                                <label class="control-label" for="focusedInput">
                                    Mobile No.</label>
                                <div class="controls">
                                    <asp:TextBox ID="txtMobile" runat="server" class="input-xlarge" />
                                     </div>
                            </div>
                           
       

                            <div class="control-group">
                                <label class="control-label" for="focusedInput">
                                    Email ID</label>
                                <div class="controls">
                                    <asp:TextBox ID="txtEmailID" runat="server" class="input-xlarge" />
                                   </div>
                            </div>

                            <div class="form-actions">
                                <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Save" OnClick="Button1_Click" />
                            </div>
                        </fieldset>
                    </div>
                </div>
            </div>
            <!--/span-->
        </div>
        <!--/row-->
    </div>
    <!--/.fluid-container-->


</asp:Content>

