<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddProject.aspx.cs" Inherits="AddProject" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
                                <i class="halflings-icon edit"></i><span class="break"></span>Project Details</h2>
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
                                        Project Name</label>
                                    <div class="controls">
                                        <asp:TextBox ID="txtName" runat="server" class="input-xlarge"  />
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtName" SetFocusOnError="true" EnableClientScript="true"></asp:RequiredFieldValidator>
                            
                                    </div>
                                </div>

                                                <div class="control-group">
                                    <label class="control-label" for="selectError">
                                        Domain</label>
                                    <div class="controls">

                                        <asp:DropDownList ID="ddlDomain" runat="server" data-rel="chosen">
                                            <asp:ListItem Value="1" Text="Software"></asp:ListItem>
                                            <asp:ListItem Value="2" Text="Real Estate"></asp:ListItem>
                                            <asp:ListItem Value="3" Text="Sewage"></asp:ListItem>
                                            <asp:ListItem Value="4" Text="Transportation"></asp:ListItem>
                                        </asp:DropDownList>

                                    </div>
                                </div>

                                <div class="control-group">
                                    <label class="control-label" for="focusedInput">
                                       Tender DeadLine</label>
                                    <div class="controls">
                                        <asp:TextBox ID="txtTenderDeadline" runat="server" class="input-xlarge datepicker"  />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtTenderDeadline" SetFocusOnError="true" EnableClientScript="true"></asp:RequiredFieldValidator>
                            
                                    </div>
                                </div>

                                <div class="control-group">
                                    <label class="control-label" for="focusedInput">
                                       Scheduled Starting</label>
                                    <div class="controls">
                                        <asp:TextBox ID="txtScheduledStart" runat="server" class="input-xlarge datepicker"  />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtTenderDeadline" SetFocusOnError="true" EnableClientScript="true"></asp:RequiredFieldValidator>
                                    </div>
                                </div>

                                <div class="control-group">
                                    <label class="control-label" for="focusedInput">
                                       Scheduled Ending</label>
                                    <div class="controls">
                                        <asp:TextBox ID="txtScheduledEnding" runat="server" class="input-xlarge datepicker"  />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtTenderDeadline" SetFocusOnError="true" EnableClientScript="true"></asp:RequiredFieldValidator>
                                    </div>
                                </div>

                                <div class="control-group">
                                    <label class="control-label" for="focusedInput">
                                       Budget</label>
                                    <div class="controls">
                                        <asp:TextBox ID="txtBudget" runat="server" class="input-xlarge"  />
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtBudget" SetFocusOnError="true" EnableClientScript="true"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid" ControlToValidate="txtBudget" SetFocusOnError="true" EnableClientScript="true" ForeColor="Red" ValidationExpression="^[0-9]*$"></asp:RegularExpressionValidator>          
                                         </div>
                                </div>
                                
                                <div class="control-group">
                                    <label class="control-label" for="focusedInput">
                                       Details</label>
                                    <div class="controls">
                                        <asp:TextBox ID="txtDetails" TextMode="MultiLine" runat="server" class="input-xlarge"  />
                                    </div>
                                </div>

                                <div class="control-group">
                                    <label class="control-label" for="focusedInput">
                                       Document</label>
                                    <div class="controls">
                                        <asp:FileUpload ID="FileUpload1" runat="server" class="input-xlarge" />
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

