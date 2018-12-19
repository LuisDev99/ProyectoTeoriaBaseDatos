<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="aprobacion_ordendesarollo.aspx.cs" Inherits="Asp.net_Sign_Up.aprobacion_ordendesarollo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   
	
	<title>Aprobacion de ordenes de desarollo</title>
	
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
                ShowHeaderWhenEmpty="true" DataKeyNames="Codigo_ord"
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

                    <asp:TemplateField HeaderText="ID Orden">

                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Codigo_ord")%>' runat="server" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtCodigo_de_orden" Text='<%# Eval("Codigo_ord")%>' runat="server" />
                        </EditItemTemplate>

                        <FooterTemplate>
                            <asp:TextBox ID="txtCodigo_de_ordenFooter" runat="server" />
                        </FooterTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="ID Cliente">

                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Id_cliente")%>' runat="server" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtCliente" Text='<%# Eval("Id_cliente")%>' runat="server" />
                        </EditItemTemplate>

                        <FooterTemplate>
                            <asp:TextBox ID="txtClienteFooter" runat="server" />
                        </FooterTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Nombre Proyecto">

                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Nombre_Proyecto")%>' runat="server" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtNombreproyecto" Text='<%# Eval("Nombre_Proyecto")%>' runat="server" />
                        </EditItemTemplate>

                        <FooterTemplate>
                            <asp:TextBox ID="txtNombreproyectoFooter" runat="server" />
                        </FooterTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Tecnologia">

                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Tecnologia")%>' runat="server" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtTecnologia" Text='<%# Eval("Tecnologia")%>' runat="server" />
                        </EditItemTemplate>

                        <FooterTemplate>
                            <asp:TextBox ID="txtTecnologiaFooter" runat="server" />
                        </FooterTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Estado">

                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Estado")%>' runat="server" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtEstado" Text='<%# Eval("Estado")%>' runat="server" />
                        </EditItemTemplate>

                        <FooterTemplate>
                            <asp:TextBox ID="txtEstadoFooter" runat="server" />
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
            <br />

            <br />
            <asp:Label ID="lbSuccesMessage" Text="" runat="server" ForeColor="ForestGreen" />
            <br />
            <asp:Label ID="lblErrorMessage" Text="" runat="server" ForeColor="Red" />

        </div>
    </form>
</body>
</html>
