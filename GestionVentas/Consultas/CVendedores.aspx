<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CVendedores.aspx.cs" Inherits="GestionVentas.Consultas.CVendedores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-weight: bold;
            background-color: #FF0000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="panel panel-primary">
        <div class="panel-heading">Consulta de Vendedores</div>
</div>
    <asp:Label ID="LabelFiltrar" runat="server" Text="Filtrar"></asp:Label>
    <p>
    </p>
    <asp:DropDownList ID="DropDownListFiltro" runat="server">
        <asp:ListItem>Todos</asp:ListItem>
        <asp:ListItem>VendedorId</asp:ListItem>
        <asp:ListItem>Nombres</asp:ListItem>
    </asp:DropDownList>
    <asp:TextBox ID="TextBoxFiltro" runat="server"></asp:TextBox>
    <asp:GridView ID="GridViewConsultaVendedores" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="225px" Width="331px">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <strong>
    <asp:Button ID="ButtonBuscar" runat="server" OnClick="ButtonBuscar_Click" Text="Buscar" CssClass="auto-style1" />
    </strong>
</asp:Content>
