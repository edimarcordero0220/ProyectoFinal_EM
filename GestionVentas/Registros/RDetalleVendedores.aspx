<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RDetalleVendedores.aspx.cs" Inherits="GestionVentas.Registros.RDetalleVendedores" %>
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


                 <%--  Input Categoria--%>

                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">Categoria Id: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:DropDownList ID="categoriaDropDownList1" runat="server">
                        </asp:DropDownList>
                        
                    </div>


                    <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">Maximo: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4"> 
                        <asp:DropDownList ID="maximoDropDownList1" runat="server">
                        </asp:DropDownList>
                        
                    </div>

                </div></div>
                <div class="col-md-1 col-sm-2 col-xs-4">
                 <asp:Button ID="Agregar" CssClass="btn btn-info btn-block btn-md" runat="server" Text="Agregar" Width="78px" />
           </div>



                <div class="form-group">
                <asp:GridView ID="DetalleGridView" CssClass="auto-style3" runat="server" ForeColor="#333333" Width="758px" ShowFooter="True" Height="115px" HorizontalAlign="Center">
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





                    </div>
    </asp:Content>
