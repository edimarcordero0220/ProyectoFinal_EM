<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RVendedores.aspx.cs" Inherits="GestionVentas.Registros.RVendedores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="panel panel-primary">
        <div class="panel-heading">Registro de Vendedores</div>

        <div class="panel-body">
            <div class="form-horizontal col-md-12" role="form">

                <%--VendedoresID--%>
                <div class="form-group">
                    <label for="IdTextBox" class="col-md-3 control-label input-sm">VendedorId: </label>
                    <div class="col-md-1 col-sm-2 col-xs-4">
                        <asp:TextBox ID="IdTextBox" runat="server" ReadOnly="True" placeholder="0" class="form-control input-sm"></asp:TextBox>
                    </div>
                    <div class="col-md-1 col-sm-2 col-xs-4">
                        <asp:LinkButton ID="BusquedaButton" CssClass="btn btn-info btn-block btn-md" data-toggle="modal" data-target="#myModal" CausesValidation="False" runat="server" Text="<span class='glyphicon glyphicon-search'></span>" />

                    </div>
                    <div class="col-md-1">
                    </div>
                </div>

                <%--Nombres--%>
                <div class="form-group">
                    <label for="NombreTextBox" class="col-md-3 control-label input-sm">Nombres</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="NombreTextBox" runat="server" Class="form-control input-sm"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="RFVNombre" runat="server" MaxLength="50" ControlToValidate="NombreTextBox" ErrorMessage="Campo Nombre obligatorio" ForeColor="Red" Display="Dynamic" SetFocusOnError="True" ToolTip="Campo Nombre obligatorio">Por favor llenar el campo Nombre</asp:RequiredFieldValidator>

                    </div>
                    <div class="col-md-1">
                    </div>
                </div>

                     <%--Descripcion--%>
                <div class="form-group">
                    <label for="DescripcionTextBox" class="col-md-3 control-label input-sm">Descripcion</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="DescripcionTextBox" runat="server" Class="form-control input-sm"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="RFVDescripcion" runat="server" ControlToValidate="DescripcionTextBox" ErrorMessage="Campo Descripcion obligatorio" ForeColor="Red" Display="Dynamic" SetFocusOnError="True" ToolTip="Campo Descripcion obligatorio">Por favor llenar el campo Descripcion</asp:RequiredFieldValidator>

                    </div>
                    <div class="col-md-1">
                    </div>
                </div>

            </div>

                 <%-- Input Mensaje Inicial--%>
                <div class="form-group">
                    <label for="MjITextBox" class="col-md-3 control-label input-sm">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Mensaje Inicial</label><div class="col-md-8">
                        <asp:TextBox ID="MjITextBox" runat="server" Class="form-control input-sm"></asp:TextBox>

                       

                    </div>
                    <div class="col-md-1">
                     </div>
                  </div>

            </div>

                 <%--Input Mensaje Final--%>
                <div class="form-group">
                    <label for="MjFTextBox" class="col-md-3 control-label input-sm">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Mensaje Final</label>&nbsp;
                    <div class="col-md-8">
                        <asp:TextBox ID="MjFTextBox" runat="server" Class="form-control input-sm"></asp:TextBox>

                        

                    </div>
                    <div class="col-md-1">
                    </div>
                </div>

            </div>

                     <%--Porciento Comision 1--%>
                 <div class="form-group">
                    <label for="Pct1TextBox" class="col-md-3 control-label input-sm">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Porciento Comision 1</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="Pct1TextBox" runat="server" Class="form-control input-sm"></asp:TextBox>

                       

                    </div>
                    <div class="col-md-1">
                    </div>
                </div>
                     <%--Porciento Comision 2--%>
                <div class="form-group">
                    <label for="Pct2TextBox" class="col-md-3 control-label input-sm">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Porciento Comision 2</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="Pct2TextBox" runat="server" Class="form-control input-sm" Width="141px"></asp:TextBox>

                        
                    </div>
                    <div class="col-md-1">
                    </div>
                </div>
                       <%--Porciento Comision 3--%>
                <div class="form-group">
                    <label for="Pct3TextBox" class="col-md-3 control-label input-sm">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Porciento Comision 3</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="Pct3TextBox" runat="server" Class="form-control input-sm"></asp:TextBox>

                       

                    </div>
                    <div class="col-md-1">
                    </div>
                </div>
                       <%--Porciento Comision 4--%>
                <div class="form-group">
                    <label for="Pct4TextBox" class="col-md-3 control-label input-sm">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Porciento Comision 4</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="Pct4TextBox" runat="server" Class="form-control input-sm"></asp:TextBox>

                        

                    </div>
                    <div class="col-md-1">
                    </div>
                </div>
                       <%--Porciento Comision 5--%>
                <div class="form-group">
                    <label for="Pct5TextBox" class="col-md-3 control-label input-sm">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Porciento Comision 5</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="Pct5TextBox" runat="server" Class="form-control input-sm"></asp:TextBox>

                        

                    </div>
                    <div class="col-md-1">
                    </div>
                </div>
                       <%--Limite Ventas--%>
                <div class="form-group">
                    <label for="LimiteVTextBox" class="col-md-3 control-label input-sm">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Limite Ventas</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="LimiteVTextBox" runat="server" Class="form-control input-sm"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="RFVLimiteV" runat="server" ControlToValidate="LimiteVTextBox" ErrorMessage="Campo Limite Ventas obligatorio" ForeColor="Red" Display="Dynamic" SetFocusOnError="True" ToolTip="Campo Limite Ventas  obligatorio">Por favor llenar el campo Limite Ventas </asp:RequiredFieldValidator>

                    </div>
                    <div class="col-md-1">
                    </div>
                </div>

            

            <div class="col-md-12">
                <asp:ValidationSummary runat="server" ID="SumaryValidation"
                    ForeColor="red"
                    DisplayMode="BulletList"
                    ShowSummary="true"
                    EnableClientScript="True"
                    Font-Bold="False"
                    CssClass=" alert alert-danger" />
            </div>

            <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>

        

        <div class="panel-footer">
            <div class="text-center">
                <div class="form-group" style="display: inline-block">
                    <asp:Button class="btn btn-info" ID="LimpiarCampos" runat="server" CausesValidation="False" Text="Limpiar"  TabIndex="1" OnClick="LimpiarCampos_Click" />
                    <asp:Button class="btn btn-success" ID="GuardarButton" runat="server" CausesValidation="True" Text="Guardar"  TabIndex="2" OnClick="GuardarButton_Click" />
                    <asp:Button class="btn btn-primary" ID="ImprimirButton" runat="server" CausesValidation="True" Text="Imprimir"  TabIndex="3" />
                    <asp:Button class="btn btn-danger" ID="AnularButton" runat="server" CausesValidation="False" Text="Anular" TabIndex="4" />
                </div>
            </div>
        </div>
    
</asp:Content>

