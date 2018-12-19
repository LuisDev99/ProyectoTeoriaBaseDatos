<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listado_equipos.aspx.cs" Inherits="Asp.net_Sign_Up.listado_equipos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   
	
	<title>Listado Equipos</title>
	
	<style>
	    body {
	        font-family: 'Avenir Next', Avenir, 'Helvetica Neue', 'Lato', 'Segoe UI', Helvetica, Arial, sans-serif;
	        color: #cecece;
	        background: #2a2b30;
	        -webkit-font-smoothing: antialiased;
	        -moz-osx-font-smoothing: grayscale;
	    }
	</style>
	
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:GridView ID="EquiposGV" runat="server" AutoGenerateColumns="false" ShowFooter="true"
                ShowHeaderWhenEmpty="true" DataKeyNames="Codigo_team"
                OnRowCommand="EquiposGV_RowCommand" 
                
                CellPadding="4" ForeColor="#333333" GridLines="None" HorizontalAlign="Center">
                <AlternatingRowStyle BackColor="#cecece" />
                <EditRowStyle BackColor="#cecece" />
                <FooterStyle BackColor="#cecece" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#2a2b30" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                <PagerStyle BackColor="#cecece" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#cecece" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />

                <Columns>

                    <asp:TemplateField HeaderText="Codigo">

                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Codigo_team")%>' runat="server" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtCodigo_de_Equipo" Text='<%# Eval("Codigo_team")%>' runat="server" />
                        </EditItemTemplate>

                        <FooterTemplate>
                            <asp:TextBox ID="txtCodigo_de_EquipoFooter" runat="server" />
                        </FooterTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Nombre del Rol">

                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Nombre_Rol")%>' runat="server" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtNombre" Text='<%# Eval("Nombre_Rol")%>' runat="server" />
                        </EditItemTemplate>

                        <FooterTemplate>
                            <asp:TextBox ID="txtNombreFooter" runat="server" />
                        </FooterTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Supervisor">

                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Supervisor")%>' runat="server" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtSupervisor" Text='<%# Eval("Supervisor")%>' runat="server" />
                        </EditItemTemplate>

                        <FooterTemplate>
                            <asp:TextBox ID="txtSupervisorFooter" runat="server" />
                        </FooterTemplate>

                    </asp:TemplateField>

                
                  
                </Columns>
            </asp:GridView>

            <br />
            <asp:Label ID="lbSuccesMessage" Text="" runat="server" ForeColor="ForestGreen" />
            <br />
            <asp:Label ID="lblErrorMessage" Text="" runat="server" ForeColor="Red" />

        </div>
    </form>
</body>
</html>
