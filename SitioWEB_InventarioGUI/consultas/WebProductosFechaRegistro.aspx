<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="WebProductosFechaRegistro.aspx.cs" Inherits="SitioWEB_InventarioGUI.consultas.WebProductosFechaRegistro" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <div class="padded">
        <div class="container">
            <h2 class="tituloForm text-center">Buscar productos por fecha de registro</h2>
            <br />
            
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            
            <table>
                <tr>
                    <td class="auto-style1">Seleccione producto:</td>
                    <td class="auto-style11">
                        <asp:DropDownList ID="cboTipInvent" runat="server" Width="300px" AutoPostBack="True" CssClass="combo2"></asp:DropDownList>
                    </td>
                    <td class="auto-style12"></td>
                </tr>
                <tr>
                    <td class="auto-style6" colspan="3">
                        <asp:Label ID="lblMensaje" runat="server" CssClass="labelErrores"></asp:Label>
                        <br /><br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Fecha inicio (*):</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtFecIni" runat="server" CssClass="combo2" Width="100px"></asp:TextBox>
                        <ajaxToolkit:CalendarExtender ID="txtFecIni_CalendarExtender" runat="server" BehaviorID="txtFecIni_CalendarExtender" TargetControlID="txtFecIni" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFecIni" CssClass="labelErrores" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style1">Fecha fin (*):</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtFecFin" runat="server" CssClass="combo2" Width="100px"></asp:TextBox>
                        <ajaxToolkit:CalendarExtender ID="txtFecFin_CalendarExtender" runat="server" BehaviorID="txtFecFin_CalendarExtender" TargetControlID="txtFecFin" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtFecFin" CssClass="labelErrores" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </td>
                    <td class="espacio"></td>
                    <td class="auto-style12">
                        <asp:Button ID="btnConsultar" runat="server" CssClass="btnConsultar" Text="Buscar" Width="135px" OnClick="btnConsultar_Click" />
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <asp:GridView ID="grvProductos" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Width="100%" AllowPaging="True" PageSize="20" AutoGenerateColumns="False" OnPageIndexChanging="grvProductos_PageIndexChanging">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Dscp_pro" HeaderText="Descripción" />
                    <asp:BoundField DataField="Pre_pro" DataFormatString="{0:n}" HeaderText="Precio">
                        <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Stk_act" HeaderText="Stock actual">
                        <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Stk_min" HeaderText="Stock mínimo">
                        <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Fec_Registro" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Fecha registro">
                        <ItemStyle HorizontalAlign="Right" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Estado" HeaderText="Estado" />
                </Columns>
                <FooterStyle BackColor="#CA4C5A" />
                <HeaderStyle BackColor="#CA4C5A" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#fdeded" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#fdeded" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>
        </div>
    </div>
</asp:Content>
