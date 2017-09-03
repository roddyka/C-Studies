<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Projeto.WEB.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="Content/bootstrap.min.css" rel="stylesheet" />

    <script src="Scripts/jquery-1.9.1.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    
</head>
<body>
    
    <div class="container">
        <h2 class="well">Controle de Clientes</h2>
        <form id="form1" runat="server" class="">
           <div class="row">
                <div class="col-md-4">
                    <h4>Seja bem vindo ao Sistema de controle de Clientes</h4>
                    Gerenciamento de clientes, realizando cadastros e consultas.
                </div>
                <div class="col-md-4">
                    <label>Selecione a opção desejada:</label>
                    <asp:DropDownList ID="ddlOpcao" runat="server" CssClass="form-control">
                        <asp:ListItem Value="" Text="-- Escolha uma Opção --"></asp:ListItem>
                         <asp:ListItem Value="1" Text="Cadastrar Clientes"></asp:ListItem>
                        <asp:ListItem Value="2" Text="Consultar Clientes"></asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <div class="text-right">
                        <asp:Button ID="btnAcesso" runat="server" Text="Entrar" CssClass="btn btn-success" OnClick="btnAcesso_Click"/>
                    </div>
                    <br />
                    <br />
                    <asp:Label ID="lblMensagem" runat="server"></asp:Label>
                </div>

            </div>
        </form>
    </div>
</body>
    <script>
        $(document).ready(function () {
            
        });
    </script>
</html>
