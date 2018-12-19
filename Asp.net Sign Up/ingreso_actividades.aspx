<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ingreso_actividades.aspx.cs" Inherits="Asp.net_Sign_Up.ingreso_actividades" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   
	
	<title>Ingreso Actividades</title>
	
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
                ShowHeaderWhenEmpty="true" DataKeyNames="Id_actividad"
                OnRowCommand="EquiposGV_RowCommand" OnRowEditing="EquiposGV_RowEditing" OnRowCancelingEdit="EquiposGV_RowCancelingEdit" OnRowUpdating="EquiposGV_RowUpdating" OnRowDeleting="EquiposGV_RowDeleting"
                
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

                    <asp:TemplateField HeaderText="ID Actividad">

                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Id_actividad")%>' runat="server" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtCodigo_de_Actividad" Text='<%# Eval("Id_actividad")%>' runat="server" />
                        </EditItemTemplate>

                        <FooterTemplate>
                            <asp:TextBox ID="txtCodigo_de_ActividadFooter" runat="server" />
                        </FooterTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Nombre">

                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Nombre")%>' runat="server" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtNombre" Text='<%# Eval("Nombre")%>' runat="server" />
                        </EditItemTemplate>

                        <FooterTemplate>
                            <asp:TextBox ID="txtNombreFooter" runat="server" />
                        </FooterTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Tiempo Estimado">

                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Tiempo_estimado")%>' runat="server" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtTiempo" Text='<%# Eval("Tiempo_estimado")%>' runat="server" />
                        </EditItemTemplate>

                        <FooterTemplate>
                            <asp:TextBox ID="txtTiempoFooter" runat="server" />
                        </FooterTemplate>

                    </asp:TemplateField>

                
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:ImageButton ImageUrl="~/images/icons8-edit-48.png" runat="server" CommandName="Edit" ToolTip="Edit" Width="20px" Height="20px" />
                            <asp:ImageButton ImageUrl="~/images/icons8-trash-48.png" runat="server" CommandName="Delete" ToolTip="Delete" Width="20px" Height="20px" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:ImageButton ImageUrl="~/images/icons8-save-48.png" runat="server" CommandName="Update" ToolTip="Update" Width="20px" Height="20px" />
                            <asp:ImageButton ImageUrl="~/images/icons8-cancel-48.png" runat="server" CommandName="Cancel" ToolTip="Cancel" Width="20px" Height="20px" />
                        </EditItemTemplate>

                        <FooterTemplate>
                            <asp:ImageButton ImageUrl="~/images/icons8-plus-48.png" runat="server" CommandName="Add" ToolTip="Add" Width="20px" Height="20px" />
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

