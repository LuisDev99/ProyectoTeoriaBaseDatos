<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="solicitud_ordendesarollo.aspx.cs" Inherits="Asp.net_Sign_Up.solicitud_ordendesarollo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
	<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1"/>
	<meta name="viewport" content="width=device-width, initial-scale=1.0"/>
	<title>Solicitud de orden de desarollo</title>
	<meta name="description" content="Blueprint: A basic template for a responsive multi-level menu" />
	<meta name="keywords" content="blueprint, template, html, css, menu, responsive, mobile-friendly" />
	<meta name="author" content="Codrops" />
	<link rel="shortcut icon" href="favicon.ico"/>
	<!-- food icons -->
	<link rel="stylesheet" type="text/css" href="css/organicfoodicons.css" />
	<!-- demo styles -->
	<link rel="stylesheet" type="text/css" href="css/demo.css" />
	<!-- menu styles -->
	<link rel="stylesheet" type="text/css" href="css/component.css" />
	<script src="js/modernizr-custom.js"></script>
    <style type="text/css">
        .icon--menu {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>



        


        <table border="0" cellpadding="0" cellspacing="0" style="width: 100%" >
            <tr>
                <td style="text-align: center; vertical-align: central"  margin:0 auto">
                    <!-- Controls here -->
                    Ingrese el nombre del proyecto:<asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    <p>
                        Tecnologia:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtTecnologia" runat="server"></asp:TextBox>
                    </p>
                        <asp:Button ID="btnSave" CssClass="icon--menu" runat="server" Text="Guardar" Width="216px" OnClick="btnSave_Click" />
                    <asp:Button ID="btnMenu" runat="server" OnClick="btnMenu_Click" Text="Menu Principal" Width="204px" />
                </td>
            </tr>
        </table>


    </form>
</body>
</html>
