<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Projeto.WEB.Clientes.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro de Cliente</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../Scripts/jquery-1.9.1.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
</head>
<body>
    <div class="container">
        <div class="well">
            <h2>Cadastro de Clientes</h2>
            <div class="text-right">
                <a href="/Default.aspx">Voltar</a> para a página inicial
            </div>
        </div>
    
        <form id="form1" runat="server">
            <div>
                <div class="col-md-4">
                    
                </div>
                <div class="col-md-4">
                    <label>Nome:</label>
                    <asp:TextBox ID="nome" CssClass="form-control" type="text" runat="server"></asp:TextBox>
                    <br />
                    <label>E-mail:</label>
                    <asp:TextBox ID="email" CssClass="form-control" type="text" runat="server"></asp:TextBox><br />
                    <label>Data de Nascimento:</label>
                    <asp:TextBox ID="dtnasc" CssClass="form-control" type="text" runat="server"></asp:TextBox><br />
                <label>Sexo:</label>
                <asp:DropDownList ID="ddlSexo" runat="server" CssClass="form-control">
                        <asp:ListItem Value="" Text="-- Escolha a opção --"></asp:ListItem>
                         <asp:ListItem Value="1" Text=""></asp:ListItem>
                        
                </asp:DropDownList>
                    <br />
                    <label>Estado Civil:</label>
                <asp:DropDownList ID="ddlEstadoCivil" runat="server" CssClass="form-control">
                        <asp:ListItem Value="" Text="-- Escolha a opção --"></asp:ListItem>
                            <asp:ListItem Value="1" Text=""></asp:ListItem>
                        
                </asp:DropDownList>
                    <br />
                    <div class="text-right">
                    <asp:Button ID="btnCadastrar" runat="server" Text="Enviar" CssClass="btn btn-success" OnClick="btnCadastrar_Click"/>
                    </div>
                    <br />
                    <br />
                    <asp:Label ID="lblMensagem" runat="server"></asp:Label>
                </div>
            </div>
        </form>
    </div>
</body>
</html>
