<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="Projeto.WEB.Clientes.Consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Consultar Cliente</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../Scripts/jquery-1.9.1.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
</head>
<body>
     <div class="container">
        <div class="well">
            <h2>Consultar Clientes</h2>
            <div class="text-right">
                <a href="/Default.aspx">Voltar</a> para a página inicial
            </div>
        </div>
        <form id="form1" runat="server">
            <div>
                <div class="col-md-12">
                    <label>Pesquisar</label>
                    <asp:TextBox ID="pesquisa" CssClass="form-control" type="text" runat="server"></asp:TextBox>
                    <br />
                    <div class="text-right">
                    <asp:Button ID="btnConsultar" runat="server" Text="Consultar" CssClass="btn btn-success" OnClick="btnConsultar_Click"/>
                    </div>
                </div>
                <div class="col-md-12">
                    <table class="table">
                        <thead>
                          <tr>
                            <th>Id</th>
                            <th>Nome</th>
                            <th>Email</th>
                              <th>Sexo</th>
                              <th>Data de Nascimento</th>
                              <th>Ação: </th>
                              <th></th>
                          </tr>
                        </thead>
                        <tbody>
                          <tr>
                            <td>1</td>
                            <td>Doe</td>
                            <td>john@example.com</td>
                              <td>Masculino</td>
                              <td>20/06/1992</td>
                              <td><asp:Button ID="btnEditar" runat="server" Text="Editar" CssClass="btn btn-warning" OnClick="btnEditar_Click"/></td>
                              <td><asp:Button ID="btnExcluir" runat="server" Text="Excluir" CssClass="btn btn-danger" OnClick="btnExcluir_Click"/></td>
                          </tr>
                        </tbody>
                      </table>
                    <br />
                    
                    
                    <br />
                    <asp:Label ID="lblMensagem" runat="server"></asp:Label>
                </div>
            </div>
        </form>
    </div>
</body>
</html>
