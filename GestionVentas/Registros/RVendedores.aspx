<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RVendedores.aspx.cs" Inherits="GestionVentas.Registros.RVendedores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="panel panel-primary">
        <div class="panel-heading">Registro de Vendedores</div>

       <div class="panel-body">
            <div class="form-horizontal col-md-12" role="form">

                 
                <%-- Input VendedoresId--%>
                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm"> Id: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4">
                        <asp:TextBox ID="IdTextBox" runat="server"  placeholder="0" class="form-control input-sm" TextMode= "Number"> </asp:TextBox>
                    </div>
                    <div class="col-md-1 col-sm-2 col-xs-4">
                        <asp:Button ID="BuscarButton" CssClass="btn btn-info btn-block btn-md" runat="server" Text="Buscar" Width="51px"  />
                        
                      
                    </div>

                </div>

                

                <%--  Input Nombres--%>

                <div class="form-group">
                    <label for="NombresTextBox" class="col-md-3 control-label input-sm">Nombres: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:TextBox ID="NombresTextBox" runat="server"  class="form-control input-sm"></asp:TextBox>
                    </div>
                     <%--  Input Descripcion--%>

                <div class="form-group">
                    <label for="DescripcionTextBox" class="col-md-3 control-label input-sm">Descripcion: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:TextBox ID="DescripcionTextBox" runat="server"  class="form-control input-sm"></asp:TextBox>
                    </div>
                    
                </div>
                </div>


                

                <%--  Input Mensaje Inicial--%>

                <div class="form-group">
                    <label for="MjeInicialTextBox" class="col-md-3 control-label input-sm">MensajeInicial : </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:TextBox ID="MjeInicialTextBox" runat="server"  class="form-control input-sm"></asp:TextBox>
                    </div>
                    <%--  Input Mensaje Final--%>

                <div class="form-group">
                    <label for="MjeFinalTextBox" class="col-md-3 control-label input-sm">MensajeFinal $: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:TextBox ID="MjeFinalTextBox" runat="server"  class="form-control input-sm"></asp:TextBox>
                    </div>
                    
                </div>
                </div>

                 

                    <%--  Input PorcientoComision1--%>

                <div class="form-group">
                    <label for="Pct1TextBox" class="col-md-3 control-label input-sm">PorcientoComision1 $: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:TextBox ID="Pct1TextBox" runat="server"  class="form-control input-sm"></asp:TextBox>
                    </div>
                    <%--  Input PorcientoComision2--%>

                <div class="form-group">
                    <label for="Pct2TextBox" class="col-md-3 control-label input-sm">PorcientoComision2 $: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:TextBox ID="Pct2TextBox" runat="server"  class="form-control input-sm"></asp:TextBox>
                    </div>
                    
                </div> 
                </div>

                

                 <%--  Input PorcientoComision3--%>

                <div class="form-group">
                    <label for="Pct3TextBox" class="col-md-3 control-label input-sm">PorcientoComision3 $: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:TextBox ID="Pct3TextBox" runat="server"  class="form-control input-sm"></asp:TextBox>
                    </div>
                     <%--  Input PorcientoComision4--%>

                <div class="form-group">
                    <label for="Pct4TextBox" class="col-md-3 control-label input-sm">PorcientoComision4 $: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:TextBox ID="Pct4TextBox" runat="server"  class="form-control input-sm"></asp:TextBox>
                        
                 </div>
                </div>

                     <%--  Input PorcientoComision5--%>

                <div class="form-group">
                    <label for="Pct5TextBox" class="col-md-3 control-label input-sm">PorcientoComision5 $: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:TextBox ID="Pct5TextBox" runat="server"  class="form-control input-sm"></asp:TextBox>
                      
                    </div>
                    </div>

                     <%--  Input LimiteVentas--%>

                <div class="form-group">
                    <label for="LimiteVTextBox" class="col-md-3 control-label input-sm">LimiteVentas $: 
                    <br />
                    <br />
                    </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:TextBox ID="LimiteVTextBox" runat="server"  class="form-control input-sm"></asp:TextBox>
                        
                         

                        <div class="col-md-12">
                
            </div>
                        </div>
                    </div>
                    </div>
                





            

        

        <div class="panel-footer">
            <div class="text-center">
                <div class="form-group" style="display: inline-block">
                    <asp:Button class="btn btn-info" ID="LimpiarCampos" runat="server" CausesValidation="False" Text="Limpiar"  TabIndex="1" OnClick="LimpiarCampos_Click1"  />
                    <asp:Button class="btn btn-success" ID="ButtonGuardar" runat="server" CausesValidation="True" Text="Guardar" OnClick="ButtonGuardar_Click"  />
                    <asp:Button class="btn btn-primary" ID="ImprimirButton" runat="server" CausesValidation="True" Text="Imprimir"  TabIndex="3" OnClick="ImprimirButton_Click" />
                    <asp:Button class="btn btn-danger" ID="AnularButton" runat="server" CausesValidation="False" Text="Anular" TabIndex="4" OnClientClick="javascript:window.print();" />
                </div>
            </div>
        </div>


            

                </div>
           
             
        </div></div>
    
</asp:Content>

