<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainMenu.aspx.cs" Inherits="Asp.net_Sign_Up.MainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" class ="no-js">
<head runat="server">
   
    <meta charset="UTF-8" />
	<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1"/>
	<meta name="viewport" content="width=device-width, initial-scale=1.0"/>
	<title>Blueprint: Multi-Level Menu</title>
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
</head>
<body>
    <form id="form1" runat="server">

        
	<!-- Main container -->
	<div class="container">
		<!-- Blueprint header -->
		<header class="bp-header cf">
			<div class="dummy-logo">
				<div class="dummy-icon foodicon foodicon--coconut"></div>
				<h2 class="dummy-heading">Fooganic</h2>
			</div>
			<div class="bp-header__main">
				<span class="bp-header__present">Blueprint <span class="bp-tooltip bp-icon bp-icon--about" data-content="The Blueprints are a collection of basic and minimal website concepts, components, plugins and layouts with minimal style for easy adaption and usage, or simply for inspiration."></span></span>
				<h1 class="bp-header__title">Multi-Level Menu</h1>
				<nav class="bp-nav">
					<a class="bp-nav__item bp-icon bp-icon--prev" href="http://tympanus.net/Blueprints/PageStackNavigation/" data-info="previous Blueprint"><span>Previous Blueprint</span></a>
					<!--a class="bp-nav__item bp-icon bp-icon--next" href="" data-info="next Blueprint"><span>Next Blueprint</span></a-->
					<a class="bp-nav__item bp-icon bp-icon--drop" href="http://tympanus.net/codrops/?p=25521" data-info="back to the Codrops article"><span>back to the Codrops article</span></a>
					<a class="bp-nav__item bp-icon bp-icon--archive" href="http://tympanus.net/codrops/category/blueprints/" data-info="Blueprints archive"><span>Go to the archive</span></a>
				</nav>
			</div>
		</header>
		<button class="action action--open" aria-label="Open Menu"><span class="icon icon--menu"></span></button>
		<nav id="ml-menu" class="menu">
			<button class="action action--close" aria-label="Close Menu"><span class="icon icon--cross"></span></button>
			<div class="menu__wrap">
				<ul data-menu="main" class="menu__level" tabindex="-1" role="menu" aria-label="All">
                    <li class="menu__item" role="menuitem"><a class="menu__link" data-submenu="submenu-1" aria-owns="submenu-1" href="#">Clientes</a></li>            
					<li class="menu__item" role="menuitem"><a class="menu__link" data-submenu="submenu-2" aria-owns="submenu-2" href="#">Reportes</a></li>
					<li class="menu__item" role="menuitem"><a class="menu__link" data-submenu="submenu-3" aria-owns="submenu-3" href="#">Ordenes de Desarollo</a></li>
					<li class="menu__item" role="menuitem"><a class="menu__link" data-submenu="submenu-4" aria-owns="submenu-4" href="#">Equipos</a></li>
                    <li class="menu__item" role="menuitem"><a class="menu__link" data-submenu="submenu-5" aria-owns="submenu-5" href="#">Empleados</a></li>
                    <li class="menu__item" role="menuitem"><a class="menu__link" data-submenu="submenu-6" aria-owns="submenu-6" href="#">Equipos de Trabajo</a></li>
                    <li class="menu__item" role="menuitem"><a class="menu__link" data-submenu="submenu-7" aria-owns="submenu-7" href="#">Actividades</a></li>
                    <li class="menu__item" role="menuitem"><a class="menu__link" data-submenu="submenu-8" aria-owns="submenu-8" href="#">Herramientas</a></li>
                    <li class="menu__item" role="menuitem"><a class="menu__link" data-submenu="submenu-9" aria-owns="submenu-9" href="#">Proyectos</a></li>
				</ul>
				<!-- Submenu 1 -->
				<ul data-menu="submenu-1" id="submenu-1" class="menu__level" tabindex="-1" role="menu" aria-label="Vegetables">
                    <asp:LinkButton runat="server" ID="imCliente" OnClick="imCliente_Click" CssClass="menu__link" Text="Ingreso/Modificacion de Clientes"></asp:LinkButton>
                    <asp:LinkButton runat="server" ID="solOrdenDesarollo" OnClick="solOrdenDesarollo_Click" CssClass="menu__link" Text="Solicitud de orden de desarollo"></asp:LinkButton>
                    <asp:LinkButton runat= "server" CssClass="menu__link" Text="Back"> </asp:LinkButton>
				</ul>
				
				<!-- Submenu 2 -->
				<ul data-menu="submenu-2" id="submenu-2" class="menu__level" tabindex="-1" role="menu" aria-label="Fruits">
					<asp:LinkButton runat="server" ID="Reportes" OnClick="Reportes_Click" CssClass="menu__link" Text="Ver Consultas"></asp:LinkButton>
                    <asp:LinkButton runat= "server" CssClass="menu__link" Text="Back"> </asp:LinkButton>
				</ul>

				<!-- Submenu 3 -->
				<ul data-menu="submenu-3" id="submenu-3" class="menu__level" tabindex="-1" role="menu" aria-label="Grains">
					<asp:LinkButton runat="server" ID="aprobacionOrdendesarollo" OnClick="aprobacionOrdendesarollo_Click" CssClass="menu__link" Text="Aprobacion/Denegacion de orden de desarollo"></asp:LinkButton>
                    <asp:LinkButton runat= "server" CssClass="menu__link" Text="Back"> </asp:LinkButton>
				</ul>
				
				<!-- Submenu 4 -->
				<ul data-menu="submenu-4" id="submenu-4" class="menu__level" tabindex="-1" role="menu" aria-label="Mylk &amp; Drinks">
					<asp:LinkButton runat="server" ID="imEquipo" OnClick="imEquipo_Click" CssClass="menu__link" Text="Ingreso/Modificacion de Equipos"></asp:LinkButton>
                    <asp:LinkButton runat="server" ID="listadoEquipo" OnClick="listadoEquipo_Click" CssClass="menu__link" Text="Listado de Equipos"></asp:LinkButton>
                    <asp:LinkButton runat= "server" CssClass="menu__link" Text="Back"> </asp:LinkButton>
				</ul>
				
                <!-- Submenu 5 -->
                <ul data-menu="submenu-5" id="submenu-5" class="menu__level" tabindex="-1" role="menu" aria-label="Mylk &amp; Drinks">
					
                    <asp:LinkButton runat= "server" ID="imEmpleado" OnClick="imEmpleado_Click" CssClass="menu__link" Text="Ingreso/Modificacion de Empleados"> </asp:LinkButton>
                    <asp:LinkButton runat= "server" CssClass="menu__link" Text="Back"> </asp:LinkButton>

				</ul>

                <!-- Submenu 6 -->
                <ul data-menu="submenu-6" id="submenu-6" class="menu__level" tabindex="-1" role="menu" aria-label="Mylk &amp; Drinks">
					
                    <asp:LinkButton runat= "server" ID="imEquipoTrabajo" OnClick="imEquipoTrabajo_Click" CssClass="menu__link" Text="Ingreso/Modificacion de Equipo de Trabajo"> </asp:LinkButton>
                    <asp:LinkButton runat= "server" CssClass="menu__link" Text="Back"> </asp:LinkButton>

				</ul>

                <!-- Submenu 7 -->
                <ul data-menu="submenu-7" id="submenu-7" class="menu__level" tabindex="-1" role="menu" aria-label="Mylk &amp; Drinks">
					
                    <asp:LinkButton runat= "server" ID="imActividades" OnClick="imActividades_Click" CssClass="menu__link" Text="Ingreso de actividades"> </asp:LinkButton>
                  <!-- -->  <asp:LinkButton runat= "server" CssClass="menu__link" Text="Ingreso de actividades por empleado/equipo de trabajo"> </asp:LinkButton>
                    <asp:LinkButton runat= "server" CssClass="menu__link" Text="Back"> </asp:LinkButton>

				</ul>

                <!-- Submenu 8 -->
                <ul data-menu="submenu-8" id="submenu-8" class="menu__level" tabindex="-1" role="menu" aria-label="Mylk &amp; Drinks">
					
                    <asp:LinkButton runat= "server" ID="imHerramienta" onClick="imHerramienta_Click" CssClass="menu__link" Text="Ingreso/Modificacion de Herramientas"> </asp:LinkButton>
                   <!-- --> <asp:LinkButton runat= "server" CssClass="menu__link" Text="Asignar herramienta a empleado y proyecto"> </asp:LinkButton>
                    <asp:LinkButton runat= "server" CssClass="menu__link" Text="Back"> </asp:LinkButton>

				</ul>

                <!-- Submenu 9 -->
                <ul data-menu="submenu-9" id="submenu-9" class="menu__level" tabindex="-1" role="menu" aria-label="Mylk &amp; Drinks">
					
                    <asp:LinkButton runat= "server" ID="cambioProyecto" OnClick="cambioProyecto_Click" CssClass="menu__link" Text="Cambio de estado proyecto"> </asp:LinkButton>
                    <asp:LinkButton runat= "server" CssClass="menu__link" Text="Back"> </asp:LinkButton>

				</ul>

			</div>
		</nav>
		<div class="content">
			<p class="info">Please choose a category</p>
			<!-- Ajax loaded content here -->
		</div>
	</div>
	<!-- /view -->
	<script src="js/classie.js"></script>
	<script src="js/dummydata.js"></script>
	<script src="js/main.js"></script>
	<script>
	(function() {
		var menuEl = document.getElementById('ml-menu'),
			mlmenu = new MLMenu(menuEl, {
				// breadcrumbsCtrl : true, // show breadcrumbs
				// initialBreadcrumb : 'all', // initial breadcrumb text
				backCtrl : false, // show back button
				// itemsDelayInterval : 60, // delay between each menu item sliding animation
				onItemClick: loadDummyData // callback: item that doesn´t have a submenu gets clicked - onItemClick([event], [inner HTML of the clicked item])
			});

		// mobile menu toggle
		var openMenuCtrl = document.querySelector('.action--open'),
			closeMenuCtrl = document.querySelector('.action--close');

		openMenuCtrl.addEventListener('click', openMenu);
		closeMenuCtrl.addEventListener('click', closeMenu);

		function openMenu() {
			classie.add(menuEl, 'menu--open');
			closeMenuCtrl.focus();
		}

		function closeMenu() {
			classie.remove(menuEl, 'menu--open');
			openMenuCtrl.focus();
		}

		// simulate grid content loading
		var gridWrapper = document.querySelector('.content');

		function loadDummyData(ev, itemName) {
			ev.preventDefault();

			closeMenu();
			gridWrapper.innerHTML = '';
			classie.add(gridWrapper, 'content--loading');
			setTimeout(function() {
				classie.remove(gridWrapper, 'content--loading');
				gridWrapper.innerHTML = '<ul class="products">' + dummyData[itemName] + '<ul>';
			}, 700);
		}
	})();
	</script>

    </form>
</body>
</html>
