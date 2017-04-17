<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="AddOfficer.aspx.cs" Inherits="AddOfficer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
  <!-- start: Content -->
            <div id="content" class="span10">
                <ul class="breadcrumb">
                    <li><i class="icon-home"></i><a href="Home.aspx">Home</a> <i class="icon-angle-right">
                    </i></li>
                    <li><i class="icon-edit"></i><a href="#">Add Project</a> </li>
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
                                       Name</label>
                                    <div class="controls">
                                        <asp:TextBox ID="txtName" runat="server" class="input-xlarge"  />
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtName" SetFocusOnError="true" EnableClientScript="true"></asp:RequiredFieldValidator>
                            
                                    </div>
                                </div>

                                <div class="control-group">
                                    <label class="control-label" for="focusedInput">
                                       Mobile No.</label>
                                    <div class="controls">
                                        <asp:TextBox ID="txtMobile" runat="server" class="input-xlarge"  />
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtMobile" SetFocusOnError="true" EnableClientScript="true"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Invalid" ControlToValidate="txtMobile" SetFocusOnError="true" EnableClientScript="true" ForeColor="Red" ValidationExpression="^[0-9]*$"></asp:RegularExpressionValidator>          
                                         </div>
                                </div>

                                <div class="control-group">
                                    <label class="control-label" for="focusedInput">
                                       EmailID</label>
                                    <div class="controls">
                                        <asp:TextBox ID="txtEmailID" runat="server" class="input-xlarge"  />
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtEmailID" SetFocusOnError="true" EnableClientScript="true"></asp:RequiredFieldValidator>
                            
                                    </div>
                                </div>

                                <div class="control-group">
                                    <label class="control-label" for="focusedInput">
                                       Username</label>
                                    <div class="controls">
                                        <asp:TextBox ID="txtUsername" runat="server" class="input-xlarge"  />
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtUsername" SetFocusOnError="true" EnableClientScript="true"></asp:RequiredFieldValidator>
                            
                                    </div>
                                </div>

                                <div class="control-group">
                                    <label class="control-label" for="focusedInput">
                                       Password</label>
                                    <div class="controls">
                                        <asp:TextBox ID="txtPassword" runat="server" class="input-xlarge" TextMode="Password" />
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtPassword" SetFocusOnError="true" EnableClientScript="true"></asp:RequiredFieldValidator>
                            
                                    </div>
                                </div>

                                <div class="control-group">
                                    <label class="control-label" for="focusedInput">
                                       Allocation Time</label>
                                    <div class="controls">
                                        <asp:TextBox ID="TextBox1" runat="server" class="input-xlarge"  />
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtName" SetFocusOnError="true" EnableClientScript="true"></asp:RequiredFieldValidator>
                            
                                    </div>
                                </div>
                                
                                <div class="form-actions">
                                   <asp:Button ID="Button1" class="btn btn-primary" runat="server" 
                                        Text="Save" onclick="Button1_Click" />
                                   
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
