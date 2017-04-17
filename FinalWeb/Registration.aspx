    <%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false"   CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   
	<!-- start: Meta -->
	<meta charset="utf-8">
	<title>Tender Timeline Tracker</title>
	<meta name="description" content="Tender Timeline Tracker">
	<meta name="author" content="Pallav Shah">
	<meta name="keyword" content="Tender Timeline Tracker">
	<!-- end: Meta -->
	
	<!-- start: Mobile Specific -->
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<!-- end: Mobile Specific -->
	
	<!-- start: CSS -->
	<link id="bootstrapstyle" href="css/bootstrap.min.css" rel="stylesheet">
	<link href="css/bootstrapresponsive.min.css" rel="stylesheet">
	<link id="basestyle" href="css/style.css" rel="stylesheet">
	<link id="basestyleresponsive" href="css/style-responsive.css" rel="stylesheet">
	<link href='http://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800&subset=latin,cyrillic-ext,latin-ext' rel='stylesheet' type='text/css'>
	<!-- end: CSS -->
	

	<!-- The HTML5 shim, for IE6-8 support of HTML5 elements -->
	<!--[if lt IE 9]>
	  	<script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
		<link id="ie" href="css/ie.css" rel="stylesheet">
	<![endif]-->
	
	<!--[if IE 9]>
		<link id="ie9style" href="css/ie9.css" rel="stylesheet">
	<![endif]-->
		
	<!-- start: Favicon -->
	<link rel="shortcut icon" href="img/favicon.ico">
	<!-- end: Favicon -->
	
			<style type="text/css">
			body { background: url(img/bg-login.jpg) !important; }
		</style>
		
		

</head>
<body>
    <form id="form1" runat="server">
    <div>
            <div id="form2" runat="server">
    <div>
    	<div class="container-fluid-full">
		<div class="row-fluid">
					
			<div class="row-fluid">
				<div class="login-box">
					<div class="icons">
						<a href="index.html"><i class="halflings-icon home"></i></a>
						<a href="#"><i class="halflings-icon cog"></i></a>
					</div>
					<h2>Enter Your Registration Details</h2>
					<div class="form-horizontal"  method="post">
						<fieldset>
							
							<div class="input-prepend" title="Name">
								<span class="add-on"><i class="halflings-icon user"></i></span>
							
            <asp:TextBox ID="txtName"  class="input-large span10" runat="server" placeholder="Type Name"></asp:TextBox>
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter all feilds" ForeColor="Red" ControlToValidate="txtName" SetFocusOnError="true" EnableClientScript="true"></asp:RequiredFieldValidator>
                            </div>
							<div class="clearfix"></div>

							<div class="input-prepend" title="Email Address">
								<span class="add-on"><i class="halflings-icon lock"></i></span>
								
			<asp:TextBox ID="txtEmail"  class="input-large span10" runat="server" placeholder="Enter Email" TextMode="SingleLine"></asp:TextBox>				
              
                            
                            </div>
							<div class="clearfix"></div>
                            	
							<div class="input-prepend" title="Mobile Number">
								<span class="add-on"><i class="halflings-icon user"></i></span>
							
            <asp:TextBox ID="txtMobile"  class="input-large span10" runat="server" placeholder="Type Mobile No."></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter all details" ForeColor="Red" ControlToValidate="txtMobile" SetFocusOnError="true" EnableClientScript="true"></asp:RequiredFieldValidator>
                            </div>
							<div class="clearfix"></div>
                            	
							<div class="input-prepend" title="Enter Password">
								<span class="add-on"><i class="halflings-icon user"></i></span>
							
            <asp:TextBox ID="txtPassword"  class="input-large span10" runat="server" placeholder="Enter Password" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtPassword" SetFocusOnError="true" EnableClientScript="true"></asp:RequiredFieldValidator>
                            </div>
							<div class="clearfix"></div>
	
							<div class="input-prepend" title="Confirm Password" >
								<span class="add-on"><i class="halflings-icon user"></i></span>
							
            <asp:TextBox ID="txtConfirm"  class="input-large span10" runat="server" placeholder="Confirm Password" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Enter all feilds" ForeColor="Red" ControlToValidate="txtConfirm" SetFocusOnError="true" EnableClientScript="true"></asp:RequiredFieldValidator>
                            </div>

							<div class="clearfix"></div>

							<div class="button-login">	
								
                <asp:Button ID="btnLogin" runat="server" Text="Register" class="btn btn-primary" 
                                    onclick="btnLogin_Click" />
							
                            </div>
							<div class="clearfix"></div>
					</div>
					<hr>
					<h3>Forgot Password?</h3>
					<p>
						No problem, <a href="#">click here</a> to get a new password.
					</p>	
				</div><!--/span-->
			</div><!--/row-->
			

	</div><!--/.fluid-container-->
	
		</div><!--/fluid-row-->
	
	<!-- start: JavaScript-->

		<script src="js/jquery-1.9.1.min.js"></script>
	<script src="js/jquery-migrate-1.0.0.min.js"></script>
	
		<script src="js/jquery-ui-1.10.0.custom.min.js"></script>
	
		<script src="js/jquery.ui.touch-punch.js"></script>
	
		<script src="js/modernizr.js"></script>
	
		<script src="js/bootstrap.min.js"></script>
	
		<script src="js/jquery.cookie.js"></script>
	
		<script src='js/fullcalendar.min.js'></script>
	
		<script src='js/jquery.dataTables.min.js'></script>

		<script src="js/excanvas.js"></script>
	<script src="js/jquery.flot.js"></script>
	<script src="js/jquery.flot.pie.js"></script>
	<script src="js/jquery.flot.stack.js"></script>
	<script src="js/jquery.flot.resize.min.js"></script>
	
		<script src="js/jquery.chosen.min.js"></script>
	
		<script src="js/jquery.uniform.min.js"></script>
		
		<script src="js/jquery.cleditor.min.js"></script>
	
		<script src="js/jquery.noty.js"></script>
	
		<script src="js/jquery.elfinder.min.js"></script>
	
		<script src="js/jquery.raty.min.js"></script>
	
		<script src="js/jquery.iphone.toggle.js"></script>
	
		<script src="js/jquery.uploadify-3.1.min.js"></script>
	
		<script src="js/jquery.gritter.min.js"></script>
	
		<script src="js/jquery.imagesloaded.js"></script>
	
		<script src="js/jquery.masonry.min.js"></script>
	
		<script src="js/jquery.knob.modified.js"></script>
	
		<script src="js/jquery.sparkline.min.js"></script>
	
		<script src="js/counter.js"></script>
	
		<script src="js/retina.js"></script>

		<script src="js/custom.js"></script>
	<!-- end: JavaScript-->

    </div>
    </div>
    
    </div>
    </form>
</body>
</html>
