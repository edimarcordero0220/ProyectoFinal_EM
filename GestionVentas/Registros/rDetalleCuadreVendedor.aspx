<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="rDetalleCuadreVendedor.aspx.cs" Inherits="GestionVentas.Registros.DetalleCuadreVendedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
      <div class="panel panel-primary">
        <div class="panel-heading">Registro de Pagos</div>

        <div class="panel-body">
            <div class="form-horizontal col-md-12" role="form">

                 
                <%-- Input ID--%>
                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm"> Id: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4">
                        <asp:TextBox ID="IdTextBox" runat="server"  placeholder="0" class="form-control input-sm" TextMode="Number"></asp:TextBox>
                    </div>
                    <div class="col-md-1 col-sm-2 col-xs-4">
                        <asp:Button ID="BuscarButton" CssClass="btn btn-info btn-block btn-md" runat="server" Text="Buscar" OnClick="BuscarButton_Click" />
                        
                      
                    </div>
                    

                </div>

                 <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm"> Cuadre Id: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4">
                        <asp:TextBox ID="CuadreIdTextBox" runat="server"  placeholder="0" class="form-control input-sm" TextMode="Number"></asp:TextBox>
                    </div>
                    <div class="col-md-1 col-sm-2 col-xs-4">
                        <asp:Button ID="BuscarCuadreButton" CssClass="btn btn-info btn-block btn-md" runat="server" Text="Buscar" />
                        
                      
                    </div>
                    

                </div>

                

                <%--  Input Vendido--%>

                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">(*)Vendido $: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:TextBox ID="VendidoTextBox" runat="server"  class="form-control input-sm"></asp:TextBox>
                    </div>
                     <%--  Input Subsidios--%>

                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">Subsidios: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:DropDownList ID="SubcidioDropDownList1" runat="server">
                        </asp:DropDownList>
                        <%--<asp:TextBox ID="SubsidiosTextBox" runat="server"  class="form-control input-sm"></asp:TextBox>--%>
                    </div>
                    
                </div>
                </div>


                

                <%--  Input Gastos--%>

                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">Gastos $: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:DropDownList ID="GastosDropDownList" runat="server">
                        </asp:DropDownList>
                        <%--<asp:TextBox ID="GastoTextBox" runat="server"  class="form-control input-sm"></asp:TextBox>--%>
                    </div>
                    <%--  Input Pagos--%>

                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">Pagos $: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:DropDownList ID="PagosDropDownList2" runat="server">
                        </asp:DropDownList>
                        <%--<asp:TextBox ID="PagosTextBox" runat="server"  class="form-control input-sm"></asp:TextBox>--%>
                    </div>
                    
                </div>
                </div>

                 

                    <%--  Input Comision--%>

                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">(*)Comision $: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:TextBox ID="ComisionTextBox" runat="server"  class="form-control input-sm"></asp:TextBox>
                    </div>
                    <%--  Input Ganancia--%>

                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">(*)Ganancia $: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:TextBox ID="GananciaTextBox" runat="server"  class="form-control input-sm"></asp:TextBox>
                    </div>
                    
                </div> 
                </div>

                

                 <%--  Input Pendiente--%>

                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">(*)Pendiente $: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:TextBox ID="PendienteTextBox" runat="server"  class="form-control input-sm"></asp:TextBox>
                    </div>
                     <%--  Input Monto--%>

                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">(*)Monto $: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:TextBox ID="MontoTextBox" runat="server"  class="form-control input-sm"></asp:TextBox>
                        
                        <asp:Button ID="AgregarButton" class="btn btn-info" runat="server" Text="Agregar" Width="106px" OnClick="AgregarButton_Click" />
                    </div>
                    
                </div>
                </div>
                 <div class="form-group">
                <asp:GridView ID="DetalleCuadreGridView" CssClass="auto-style3" runat="server" ForeColor="#333333" Width="758px" ShowFooter="True" Height="115px" HorizontalAlign="Center">
                <AlternatingRowStyle BackColor="White" Font-Bold="False" />
                <EditRowStyle BackColor="#2461BF" HorizontalAlign="Center" VerticalAlign="Middle" />
                <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Bottom" />
                <FooterStyle BackColor="#C0C0C0" Font-Bold="True" ForeColor="White" BorderColor="white" BorderWidth="2px" HorizontalAlign="Justify" VerticalAlign="Top" />
                <HeaderStyle BackColor="#C0C0C0" Font-Bold="True" ForeColor="White" BorderStyle="Outset" Font-Italic="True" Font-Size="12pt" HorizontalAlign="Center" VerticalAlign="Middle" />
                <PagerStyle BackColor="#F8F8FF" ForeColor="White" HorizontalAlign="Center" BorderColor="Black" BorderWidth="2px" />
                <RowStyle BackColor="#EFF3FB" BorderColor="Black" BorderStyle="None" BorderWidth="2px" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" BorderStyle="Solid" BorderWidth="3px" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" BorderStyle="Solid" BorderWidth="3px" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
                </div>
                <div class="panel-footer">
            <div class="text-center">
                <div class="form-group" style="display: inline-block">
                <asp:Button class="btn btn-info" ID="LimpiarButton" runat="server" Text="Limpiar" />
                <asp:Button class="btn btn-success" ID="GuardarButton" runat="server" Text="Guardar" OnClick="GuardarButton_Click" />
                <asp:Button class="btn btn-danger" ID="Button3" runat="server" Text="Button" />
 </div>
            </div>
        </div>

                </div>
             
        </div></div>
</asp:Content>
