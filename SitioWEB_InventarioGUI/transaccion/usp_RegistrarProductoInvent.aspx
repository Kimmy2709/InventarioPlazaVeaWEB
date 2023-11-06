<%@ Page Title="" Language="C#" MasterPageFile="~/DemoMaster.Master" AutoEventWireup="true" CodeBehind="usp_RegistrarProductoInvent.aspx.cs" Inherits="SitioWEB_InventarioGUI.transaccion.usp_RegistrarProductoInvent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Cabecera" runat="server">
       <style type="text/css">
        .auto-style4 {
            height: 18px;
        }
           .auto-style6 {
               width: 128px;
           }
           .auto-style7 {
               width: 124px;
           }
           .auto-style8 {
               width: 117px;
           }
           .auto-style9 {
               width: 115px;
           }
           .auto-style19 {
               width: 204px;
           }
           .auto-style21 {
               width: 190px;
               height: 30px;
               color: #0799b6;
               font-weight:bold;
           }
           .auto-style24 {
               width: 483px;
               height: 30px;
           }
           .auto-style26 {
               width: 550px;
           }
           .auto-style27 {
               width: 544px;
           }
           .auto-style33 {
               width: 310px;
           }
           .auto-style34 {
               width: 310px;
               height: 30px;
           }
           .auto-style41 {
               height: 18px;
               width: 656px;
           }
           .auto-style42 {
               text-align: center;
               width: 656px;
           }
           .auto-style43 {
               width: 656px;
           }
           
           .auto-style44 {
               width: 360px;
               height: 30px;
               color: #0799b6;
               font-weight: bold;
           }
           .auto-style45 {
               width: 360px;
           }
           
           .auto-style46 {
               width: 341px;
               height: 24px;
           }
           .auto-style47 {
               width: 561px;
               height: 24px;
           }
           .auto-style48 {
               width: 360px;
               height: 24px;
           }
           
           .auto-style51 {
               height: 30px;
               width: 561px;
           }
           .auto-style52 {
               width: 561px;
           }
           
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Principal" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

     <asp:UpdatePanel ID="UpdatePanel1" runat="server">

       <%-- Coloque esta  etiqueta Triggers (de AJAX) dentro del UpdatePanel1 para la ejecucion 
           del evento click del boton btnGrabarOC y el correcto envio de la proforma al grabar la Orden de compra.--%>
        <Triggers>
               <asp:PostBackTrigger ControlID="btnVerGrabar" />              
        </Triggers>

        <ContentTemplate >
            <div class="padded">
        <div class="container">

                        <h2 class="tituloForm text-center">Registrar Orden de Entrada </h2>
            <br />
    <table>
             
                    <caption>
                      
                        <br>
                    
                        <tr>
                            <td class="auto-style21">Descripción:</td>
                            <td colspan="2" style="height: 21px">
                                <asp:TextBox ID="txtDescripcion" runat="server" CssClass="box-transac" Width="300px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style21">Precio:</td>
                            <td colspan="2" style="height: 21px">
                                <asp:TextBox ID="txtPrecio" runat="server" CssClass="box-transac" Width="96px" MaxLength="10"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style21">Stock actual:</td>
                            <td class="auto-style51">
                                <asp:TextBox ID="txtStockAct" runat="server" CssClass="box-transac" Width="96px"></asp:TextBox>
                            </td>
                            <td class="auto-style44">Stock mínimo:</td>
                            <td class="auto-style34">
                                <asp:TextBox ID="txtStockMin" runat="server" CssClass="box-transac" Width="96px"></asp:TextBox>
                            </td>
                            <td class="auto-style24"></td>
                        </tr>
                        <tr>
                            <td class="auto-style21">&nbsp;</td>
                            <td class="auto-style52">
                                <asp:CheckBox ID="chkEstado" runat="server" Text="Activo" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style21">Seleccione area:</td>
                            <td class="auto-style51">
                                <asp:DropDownList ID="cboArea" runat="server" AutoPostBack="True" CssClass="box-transac" Width="300px" OnSelectedIndexChanged="cboArea_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                            <td class="auto-style44">Seleccione unidad de medida:</td>
                            <td class="auto-style34">
                                <asp:DropDownList ID="cboUniMedida" runat="server" AutoPostBack="True" CssClass="box-transac" Width="300px">
                                </asp:DropDownList>
                            </td>
                            <td class="auto-style24"></td>
                        </tr>
                        <tr>
                            <td class="auto-style21">Seleccione sección:</td>
                            <td class="auto-style52">
                                <asp:DropDownList ID="cboSeccion" runat="server" AutoPostBack="True" CssClass="box-transac" Width="300px" OnSelectedIndexChanged="cboSeccion_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                            <td class="auto-style45"></td>
                        </tr>
                        <tr>
                            <td class="auto-style21">Seleccione linea:</td>
                            <td class="auto-style52">
                                <asp:DropDownList ID="cboLinea" runat="server" AutoPostBack="True" CssClass="box-transac" Width="300px" OnSelectedIndexChanged="cboLinea_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                            <td class="auto-style45">
                                <asp:Label ID="lblTipInvent" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style21">Seleccione familia:</td>
                            <td class="auto-style52">
                                <asp:DropDownList ID="cboFamilia" runat="server" AutoPostBack="True" CssClass="box-transac" Width="300px" OnSelectedIndexChanged="cboFamilia_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                            <td class="auto-style45">
                                <asp:Label ID="lblCantInv" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style21">Seleccione subfamilia:</td>
                            <td class="auto-style52">
                                <asp:DropDownList ID="cboSubFamilia" runat="server" CssClass="box-transac" Width="300px">
                                </asp:DropDownList>
                            </td>
                            <td class="auto-style45">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style21">
                                <br />
                            </td>
                            <td colspan="2">&nbsp;</td>
                        </tr>
                        <tr>
                            <td></td>
                        </tr>
                        <tr>
                            <td></td>
                        </tr>
                        <tr>
                            <td class="auto-style46"></td>
                            <td class="auto-style47">&nbsp;</td>
                            <td class="auto-style48">
                                <asp:Button ID="btnAgregar" runat="server" CssClass="btn-transac" Text="Agregar Detalle" Width="216px" OnClick="btnAgregar_Click" />
                            </td>
                            <td>
                                <asp:Button ID="btnVerGrabar" runat="server" CssClass="btn-transac" Text="Grabar" Width="150px" OnClick="btnVerGrabar_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style19">
                                &nbsp;</td>
                            <td class="auto-style52">&nbsp;</td>
                            <td class="auto-style45">&nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="3">&nbsp;<asp:GridView ID="grDetalles" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" ShowHeaderWhenEmpty="True" Width="1076px">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="Cod_pro" HeaderText="Codigo " />
                                    <asp:BoundField DataField="Dscp_pro" HeaderText="Nombre" />
                                    <asp:BoundField DataField="Pre_pro" HeaderText="Precio" />
                                    <asp:BoundField DataField="Fec_Registro" HeaderText="Fecha registro" />
                                    <asp:BoundField DataField="Usu_Registro" HeaderText="Usuario registro" />
                                    <asp:BoundField DataField="Dscp_tip_invent" HeaderText="Tipo inventario" />
                                    <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
                                </Columns>
                                <FooterStyle BackColor="#03788f" />
                                <HeaderStyle BackColor="#03788f" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#c2f1f2" ForeColor="Black" HorizontalAlign="Right" />
                                <RowStyle BackColor="#d9f9fa" />
                                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                                <SortedAscendingHeaderStyle BackColor="#848384" />
                                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                                <SortedDescendingHeaderStyle BackColor="#575357" />
                                </asp:GridView>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style19">&nbsp;</td>
                            <td colspan="2">&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                            <td class="auto-style33"></td>
                        </tr>
                        <tr>
                            <td colspan="3">&nbsp;</td>
                        </tr>
                        <caption>
                        </caption>
               
        </table>
            <%-- Aqui va el popup de Detalle --%>
            <%--el link button o cualquiero otro control para el manejo del modal (TargetControl)--%>
           <asp:LinkButton Text="" ID = "lnkDetalle" runat="server" />
            <%--El  panel con el contenido--%>
              <asp:Panel ID="PanelDetalle" runat="server" CssClass="CajaDialogo" align="center" Style="display:normal" Width="600px">
          
            <table style="border: Solid 3px #D55500;"
                cellpadding="0" cellspacing="0" width="600px" >
                <tr style="background-color: #03788f">
                    <td colspan="2" style="height: 10%; color: White; font-weight: bold; font-size: larger"
                        align="center">
                        Registrar Detalle de Ingreso
                    </td>
                </tr>
                <tr>
                    <td align="right" class="auto-style43">
                        &nbsp;</td>
                      <td align="left" class="auto-style6">
                          &nbsp;</td>
                </tr>
                <tr>
                    <td align="right" class="auto-style43"></td>
                    <td align="left" class="auto-style6"></td>
                </tr>
                <tr>
                    <td align="right" class="auto-style21">Tipo de inventario:</td>
                    <td align="left" class="auto-style21">
                        <asp:DropDownList ID="cboProducto" runat="server"  Width="192px" CssClass="box-transac">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="auto-style21">&nbsp;</td>
                    <td align="left" class="auto-style21">&nbsp;</td>
                </tr>
                <tr>
                    <td align="right" class="auto-style21">
                        Cantidad Ingresada:
                    </td>
                    <td align="left" class="auto-style8">
                        <asp:TextBox ID="txtCanPed" runat="server" Width="70px" CssClass="box-transac"></asp:TextBox>
                        <ajaxToolkit:MaskedEditExtender ID="txtCanPed_MaskedEditExtender" runat="server" BehaviorID="txtCanPed_MaskedEditExtender" Century="2000" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" Mask="999" MaskType="Number" TargetControlID="txtCanPed" />
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2" class="auto-style9">
                        <asp:Label ID="lblMensajeDetalle" runat="server" CssClass="labelErrores" Width="583px"></asp:Label>
                    </td>
                </tr>
               
                     <tr>
                         <td class="auto-style41">
                             </td>
                         <td class="auto-style4">
                             </td>
                </tr>
              
                <tr>
                    <td class="auto-style43">&nbsp;</td>
                    <td class="auto-style26">&nbsp;</td>
                </tr>
              
                <tr>
                    <td class="auto-style42">
                        <asp:Button ID="btnGrabarDetalle" runat="server" Text="Grabar" Width="100px" CssClass="btn-detalle" OnClick="btnGrabarDetalle_Click" />
                    </td>
                    <td class="center">
                        <asp:Button ID="btnCancelarDetalle" runat="server" Text="Cancelar" Width="137px" CssClass="btn-detalle" />
                    </td>
                </tr>
              
                <tr>
                    <td class="auto-style43"></td>
                    <td class="auto-style27"></td>
                </tr>
              
                <tr>
                    <td class="auto-style43">&nbsp;</td>
                    <td class="auto-style27">&nbsp;</td>
                </tr>
              
            </table>
                  </div>

                  </div>      
        </asp:Panel>
            <%--El modalpoput extender : vease el TargetControl que apunta al linkbutton y el popuconttol ID que apunhta al panel--%> 
      <ajaxToolkit:ModalPopupExtender ID="PopDetalle" runat="server" BackgroundCssClass="FondoAplicacion"  
        TargetControlID="lnkDetalle" PopupControlID="PanelDetalle"  >
    </ajaxToolkit:ModalPopupExtender>
  
    <%--Este es el popup que contiene los mensajes de error--%>
             <%--el link button o cualquiero otro control para el manejo del modal--%>
              <asp:LinkButton ID="lnkMensaje" runat="server" ></asp:LinkButton>
             <%--El  panel con el contenido del mensaje--%>
               <asp:Panel ID="pnlMensaje" runat="server" CssClass="CajaDialogo" Style="display: normal;" Width="500"  align="center" > 
                    <table border="0" width="500px" > 
                        <tr style="background-color: #03788f"  align="center"> 
                            <td align="center" class="auto-style7" > 
                                <asp:Label ID="lblTitulo" runat="server" Text="Mensaje" style="height: 40px; color: White; font-weight: bold; font-size: 22px"
                        align="center" /> 
                            </td> 
                            
                        </tr> 
                         <tr>
                             <td class="center" colspan="2">
                                  &nbsp;</td>
                         </tr>
                         <tr>
                             <td class="center" colspan="2">
                                 <asp:Label ID="lblMensajePopup" runat="server" CssClass="labelTitulo" />
                             </td>
                        </tr>
                         <tr>
                             <td class="auto-style7">&nbsp;</td>
                        </tr>
                         <tr>
                             <td class="center" colspan="2">
                                  <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="btn-detalle " /> 
                             </td>
                         </tr>
                        <tr>
                            <td class="center" colspan="2">&nbsp;</td>
                        </tr>
                    </table> 
                 </asp:Panel> 
            <ajaxToolkit:ModalPopupExtender ID="PopMensaje" runat="server" TargetControlID="lnkMensaje" 
                    PopupControlID="pnlMensaje" BackgroundCssClass="FondoAplicacion" OkControlID="btnAceptar" 
                     />
               <%--Este es el popup que contiene la grabacion de la OC y adjuntar la proforma--%>
             <%--el link button o cualquiero otro control para el manejo del modal--%>
            
     </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>