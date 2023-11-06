<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="WebGraficosProveedores.aspx.cs" Inherits="SitioWEB_InventarioGUI.consultas.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <div class="padded">
    <div class="container">
        <div class="row">
            <h2 class="tituloForm text-center">Estadística de Proveedores por Distrito</h2>  
           
             <p class="tituloForm">
                <asp:Label ID="lblMensaje" runat="server" CssClass="labelErrores"></asp:Label>
            </p>
            
            <table class="auto-style1" >
                <tr>
                    <td colspan="2">
                        <asp:GridView ID="grvProveedores" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#39586D" GridLines="None" Width="100%">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:BoundField DataField="Codigo" HeaderText="Codigo ubigeo" />
                                <asp:BoundField DataField="Distrito" HeaderText="Distrito">
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                                <asp:BoundField DataField="Cantidad" HeaderText="Cantidad">
                                <ItemStyle HorizontalAlign="Center" />
                                </asp:BoundField>
                            </Columns>
                            <EditRowStyle BackColor="#7F99B2" />
                            <FooterStyle BackColor="#7F99B2" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#7F99B2" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#D2D7DB" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#D2D7DB" />
                            <SelectedRowStyle BackColor="#7f99b2" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#7f99b2" />
                            <SortedAscendingHeaderStyle BackColor="#7f99b2" />
                            <SortedDescendingCellStyle BackColor="#D4DFE1" />
                            <SortedDescendingHeaderStyle BackColor="#15524A" />
                        </asp:GridView>
                    </td>
                </tr>
                
               
                
                <tr>
                    <td>
                        <asp:Chart ID="grvProv" runat="server" Height="652px" Width="1290px" Palette="Grayscale" PaletteCustomColors="Navy; " CssClass="grafico">
                            <series>
                                <asp:Series Name="Series1"  >
                                </asp:Series>
                            </series>
                            <chartareas>
                                <asp:ChartArea Name="ChartArea1">
                                    <AxisX MaximumAutoSize="10">
                                    </AxisX>
                                </asp:ChartArea>
                            </chartareas>
                    
                            <Titles >
                                <asp:Title Name="Title1" Text="Cantidad de Proveedores por distrito">
                                </asp:Title>
                            </Titles>
                        </asp:Chart>
                        <br />
                    </td>
            
                </tr>
            </table>    
        </div> 
    </div>
    </div>
    <br/>
    <br/>
</asp:Content>
