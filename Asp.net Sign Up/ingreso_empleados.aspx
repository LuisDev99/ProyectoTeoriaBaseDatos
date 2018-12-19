<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ingreso_empleados.aspx.cs" Inherits="Asp.net_Sign_Up.ingreso_empleados" %>

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
                ShowHeaderWhenEmpty="true" DataKeyNames="Codigo_emp"
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

                    <asp:TemplateField HeaderText="Codigo Empleado">

                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Codigo_emp")%>' runat="server" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtCodigo_de_Empleado" Text='<%# Eval("Codigo_emp")%>' runat="server" />
                        </EditItemTemplate>

                        

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Primer Nombre">

                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Primer_N")%>' runat="server" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtPrimer_N" Text='<%# Eval("Primer_N")%>' runat="server" />
                        </EditItemTemplate>

                        <FooterTemplate>
                            <asp:TextBox ID="txtPrimer_NFooter" runat="server" />
                        </FooterTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Segundo Nombre">

                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Segundo_N")%>' runat="server" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtSegundo_N" Text='<%# Eval("Segundo_N")%>' runat="server" />
                        </EditItemTemplate>

                        <FooterTemplate>
                            <asp:TextBox ID="txtSegundo_NFooter" runat="server" />
                        </FooterTemplate>

                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="Primer Apellido">

                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Primer_A")%>' runat="server" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtPrimer_A" Text='<%# Eval("Primer_A")%>' runat="server" />
                        </EditItemTemplate>

                        <FooterTemplate>
                            <asp:TextBox ID="txtPrimer_AFooter" runat="server" />
                        </FooterTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Segundo Apellido">

                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Segundo_A")%>' runat="server" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtSegundo_A" Text='<%# Eval("Segundo_A")%>' runat="server" />
                        </EditItemTemplate>

                        <FooterTemplate>
                            <asp:TextBox ID="txtSegundo_AFooter" runat="server" />
                        </FooterTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Calle">

                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Calle")%>' runat="server" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtCalle" Text='<%# Eval("Calle")%>' runat="server" />
                        </EditItemTemplate>

                        <FooterTemplate>
                            <asp:TextBox ID="txtCalleFooter" runat="server" />
                        </FooterTemplate>

                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="Avenida">

                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Avenida")%>' runat="server" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtAvenida" Text='<%# Eval("Avenida")%>' runat="server" />
                        </EditItemTemplate>

                        <FooterTemplate>
                            <asp:TextBox ID="txtAvenidaFooter" runat="server" />
                        </FooterTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="No_Casa">

                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("No_Casa")%>' runat="server" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtNo_Casa" Text='<%# Eval("No_Casa")%>' runat="server" />
                        </EditItemTemplate>

                        <FooterTemplate>
                            <asp:TextBox ID="txtNo_CasaFooter" runat="server" />
                        </FooterTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Ciudad">

                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Ciudad")%>' runat="server" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtCiudad" Text='<%# Eval("Ciudad")%>' runat="server" />
                        </EditItemTemplate>

                        <FooterTemplate>
                            <asp:TextBox ID="txtCiudadFooter" runat="server" />
                        </FooterTemplate>

                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="Departamento">

                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Departamento")%>' runat="server" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtDepartamento" Text='<%# Eval("Departamento")%>' runat="server" />
                        </EditItemTemplate>

                        <FooterTemplate>
                            <asp:TextBox ID="txtDepartamentoFooter" runat="server" />
                        </FooterTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Referencia">

                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Referencia")%>' runat="server" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtReferencia" Text='<%# Eval("Referencia")%>' runat="server" />
                        </EditItemTemplate>

                        <FooterTemplate>
                            <asp:TextBox ID="txtReferenciaFooter" runat="server" />
                        </FooterTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Telefono">

                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Telefono")%>' runat="server" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtTelefono" Text='<%# Eval("Telefono")%>' runat="server" />
                        </EditItemTemplate>

                        <FooterTemplate>
                            <asp:TextBox ID="txtTelefonoFooter" runat="server" />
                        </FooterTemplate>

                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="Fecha_Nacimiento">

                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Fecha_Nacimiento")%>' runat="server" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtFecha_Nacimiento" Text='<%# Eval("Fecha_Nacimiento")%>' runat="server" />
                        </EditItemTemplate>

                        <FooterTemplate>
                            <asp:TextBox ID="txtFecha_NacimientoFooter" runat="server" />
                        </FooterTemplate>

                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="Fecha_Contratacion">

                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Fecha_Contratacion")%>' runat="server" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtFecha_Contratacion" Text='<%# Eval("Fecha_Contratacion")%>' runat="server" />
                        </EditItemTemplate>

                        <FooterTemplate>
                            <asp:TextBox ID="txtFecha_ContratacionFooter" runat="server" />
                        </FooterTemplate>

                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="Salario">

                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Salario")%>' runat="server" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtSalario" Text='<%# Eval("Salario")%>' runat="server" />
                        </EditItemTemplate>

                        <FooterTemplate>
                            <asp:TextBox ID="txtSalarioFooter" runat="server" />
                        </FooterTemplate>

                    </asp:TemplateField>


                    <asp:TemplateField HeaderText="Id_Equipo">

                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Id_Equipo")%>' runat="server" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtId_Equipo" Text='<%# Eval("Id_Equipo")%>' runat="server" />
                        </EditItemTemplate>

                        <FooterTemplate>
                            <asp:TextBox ID="txtId_EquipoFooter" runat="server" />
                        </FooterTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Id_EquipoP">

                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("Id_EquipoP")%>' runat="server" />
                        </ItemTemplate>

                        <EditItemTemplate>
                            <asp:TextBox ID="txtId_EquipoP" Text='<%# Eval("Id_EquipoP")%>' runat="server" />
                        </EditItemTemplate>

                        <FooterTemplate>
                            <asp:TextBox ID="txtId_EquipoPFooter" runat="server" />
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
