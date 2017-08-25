<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exclusao.aspx.cs" Inherits="Projeto.WEB.Clientes.Exclusao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../Scripts/jquery-1.9.1.min.js"></script>
    <script src="../Scripts/bootstrap.js"></script>

</head>
<body>
    <div class="container">
    <div class="well well-sm">
        <h2>Exclusão de Cliente</h2>
         <div class="text-right">
                <a href="Consulta.aspx">Voltar</a> para a consulta
            </div>
        
    </div>
    <div class="col-sm-4"></div>
    <form id="form1" runat="server">
      
     <div class="alert alert-danger col-sm-4">
         <asp:Panel ID="painelExclusao" runat="server">

         
         <h4>Deseja realmente excluir este cliente?</h4>
         <asp:HiddenField ID="txtCodigo" runat="server" />

         Nome do Cliente: <asp:Label ID="lblNome" runat="server"></asp:Label>
         <br />
         Email: <asp:Label ID="lblEmail" runat="server"></asp:Label>
         <br />
         Data de Nascimento: <asp:Label ID="lblDatanascimento" runat="server"></asp:Label>
         <br />
         Sexo: <asp:Label ID="lblSexo" runat="server"></asp:Label>
         <br />
         Estado Civil: <asp:Label ID="lblEstadoCivil" runat="server"></asp:Label>
         <br />
         <br />
         <asp:Button ID="btnExclusao" runat="server" Text="Confirmar Exclusão" CssClass="btn btn-danger" OnClick="btnExclusao_Click"/>
         <br />
         <br />
         </asp:Panel>
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        
     </div>
    </form>
     <div class="col-sm-4"></div>
        </div>
</body>
</html>
