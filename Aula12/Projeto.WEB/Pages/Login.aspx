<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Layout.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Projeto.WEB.Pages.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="conteudoPrincipal" runat="server">

    <h4>Realizar Autenticação</h4>
    <a href="/Default.aspx">Página inicial</a>
    <hr />

    <div class="row">
        <div class="col-md-4">

            <label>Informe seu Login:</label>
            <asp:TextBox ID="txtLogin" runat="server"
                CssClass="form-control" placeholder="Login de Acesso" />  
            <asp:RequiredFieldValidator
                ID="requiredLogin"
                runat="server"
                ControlToValidate="txtLogin"
                ErrorMessage="Por favor, informe seu login de acesso"
                Display="Dynamic"
                ForeColor="Red"
                ValidationGroup="formularioLogin"
            />
            <br />

            <label>Informe sua Senha:</label>
            <asp:TextBox ID="txtSenha" runat="server"
                CssClass="form-control" placeholder="Senha de Acesso"
                TextMode="Password" />
            <asp:RequiredFieldValidator
                ID="requiredSenha"
                runat="server"
                ControlToValidate="txtSenha"
                ErrorMessage="Por favor, informe sua senha de acesso"
                Display="Dynamic"
                ForeColor="Red"
                ValidationGroup="formularioLogin"
            />
            <br />

            <asp:Button ID="btnAcesso" runat="server"
                Text="Acessar Sistema" CssClass="btn btn-success"
                ValidationGroup="formularioLogin"
                OnClick="btnAcesso_Click" />
            <br />
            <br />

            <asp:Label ID="lblMensagem" runat="server" 
                CssClass="text-danger" />
        </div>
    </div>

</asp:Content>
