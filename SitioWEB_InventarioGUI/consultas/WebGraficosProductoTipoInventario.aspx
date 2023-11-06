<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="WebGraficosProductoTipoInventario.aspx.cs" Inherits="SitioWEB_InventarioGUI.consultas.WebForm1" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 1528px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <div class="padded">
    <div class="container">
     <h2 class="tituloForm text-center">Estadística de Cantidad de productos por tipo</h2>  
        <div class="row">
            
                <p class="tituloForm"><asp:Label ID="lblMensaje" runat="server" CssClass="labelErrores"></asp:Label></p>
                <table class="auto-style1">
                    <tr>
                        <td colspan="2" class="auto-style2">
                            <asp:GridView ID="grvTiendas" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#303C7E" GridLines="None" Width="100%">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="Cod_tip_invent" HeaderText="Codigo por tipo de inventario">
                                    <ItemStyle HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Dscp_tip_invent" HeaderText="Tipo  de Inventario">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="CantidadProductos" HeaderText="Cantidad de productos">
                                    </asp:BoundField>
                                </Columns>
                                <EditRowStyle BackColor="#7C6F57" />
                                <FooterStyle BackColor="#849997" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#849997" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#E3EAEB" />
                                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#EBE8E0" />
                                <SortedAscendingHeaderStyle BackColor="#EBE8E0" />
                                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                                <SortedDescendingHeaderStyle BackColor="#15524A" />
                            </asp:GridView>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Chart ID="grvTienda" runat="server" Height="652px" Width="1174px" Palette="SeaGreen" PaletteCustomColors="Navy; ActiveCaption">
                                <series>
                                    <asp:Series Name="Series1" ChartType="StackedColumn"  >
                                    </asp:Series>
                                </series>
                                <chartareas>
                                    <asp:ChartArea Name="ChartArea1">
                                        <AxisX MaximumAutoSize="10">
                                        </AxisX>
                                    </asp:ChartArea>
                                </chartareas>
                                <Titles>
                                    <asp:Title Name="Title1" Text="Cantidad de Productos por tipo de inventario">
                                    </asp:Title>
                                </Titles>
                            </asp:Chart>
                        </td>
            
                    </tr>
                </table>
             
        </div>
    </div>
    </div>
    <br/>
    <br/>
</asp:Content>
