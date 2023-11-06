<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="WebProductosPorCategoria.aspx.cs" Inherits="SitioWEB_InventarioGUI.consultas.WebProductosPorCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
    <style type="text/css">
        .auto-style6 {
            margin-left: 31;
        }
        .auto-style10 {
            font-family: 'Cutive Mono', monospace;
            color: #af5700;
            font-weight: bold;
            font-size: 19px;
            width: 283px;
        }
        .auto-style11 {
            align-items: center;
            width: 252px;
            text-align: center;
        }
        .auto-style12 {
            align-items: center;
            width: 409px;
            text-align: center;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server"  >
    <div class="padded">
        <div class="container">
            <h2 class="tituloForm text-center">Buscar productos por categoria</h2>
            <br />
            
            <table >
                <tr>
                    <td class="auto-style10"> Seleccione area:</td>
                    
                    <td class="auto-style11">
                        <asp:DropDownList ID="cboArea" runat="server" Width="300px" AutoPostBack="True" OnSelectedIndexChanged="cboArea_SelectedIndexChanged" CssClass="comboEstilo">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style12"></td>
                </tr>
                <tr>
                    <td class="auto-style10">Seleccione sección:</td>
                    
                    <td class="auto-style11">
                        <asp:DropDownList ID="cboSeccion" runat="server" Width="300px" OnSelectedIndexChanged="cboSeccion_SelectedIndexChanged" AutoPostBack="True" CssClass="comboEstilo">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style12"></td>
                </tr>
                <tr>
                    <td class="auto-style10">Seleccione linea:</td>
                    
                    <td class="auto-style11">
                        <asp:DropDownList ID="cboLinea" runat="server" Width="300px" OnSelectedIndexChanged="cboLinea_SelectedIndexChanged" AutoPostBack="True" CssClass="comboEstilo">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style12"></td>
                </tr>
                <tr>
                    <td class="auto-style10">Seleccione familia:</td>
                    
                    <td class="auto-style11">
                        <asp:DropDownList ID="cboFamilia" runat="server" Width="300px" OnSelectedIndexChanged="cboFamilia_SelectedIndexChanged" AutoPostBack="True" CssClass="comboEstilo">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style12"></td>
                </tr>
                <tr>
                    <td class="auto-style10">Seleccione subfamilia:</td>
                   
                    <td class="auto-style11">
                        <asp:DropDownList ID="cboSubFamilia" runat="server" Width="300px" CssClass="comboEstilo">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style12" >
                        <asp:Button ID="btnBuscar" runat="server" CssClass="btn-danger" Text="Buscar" Width="135px" OnClick="btnBuscar_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6" colspan="3">
                        <asp:Label ID="lblMensaje" runat="server" CssClass="labelErrores"></asp:Label>
                        <br />
                        
                        <br />
                    </td>
                </tr>
            </table>
            <asp:GridView ID="grvCategoriaProducto" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Width="100%" AllowPaging="True" PageSize="20" AutoGenerateColumns="False" OnPageIndexChanging="grvCategoriaProducto_PageIndexChanging">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                                <asp:BoundField DataField="Dscp_pro" HeaderText="Descripcion" />
                                <asp:BoundField DataField="Pre_pro" DataFormatString="{0:n}" HeaderText="Precio">
                                <ItemStyle HorizontalAlign="Right" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Stk_act" HeaderText="Stock actual" >
                                <ItemStyle HorizontalAlign="Right" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Stk_min" HeaderText="Stock mínimo" >
                                <ItemStyle HorizontalAlign="Right" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Fec_Registro" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Fecha registro">
                                    <ItemStyle HorizontalAlign="Right" />
                                </asp:BoundField>
                            </Columns>
                            <FooterStyle BackColor="#ea9247" />
                            <HeaderStyle BackColor="#ea9247" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                            <RowStyle BackColor="#F7F7DE" />
                            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#FBFBF2" />
                            <SortedAscendingHeaderStyle BackColor="#848384" />
                            <SortedDescendingCellStyle BackColor="#EAEAD3" />
                            <SortedDescendingHeaderStyle BackColor="#575357" />
                        </asp:GridView>
        </div>
    </div>
</asp:Content>
