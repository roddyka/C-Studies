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
                    <asp:RequiredFieldValidator 
                        ID="requiredNome" 
                        runat="server" 
                        ControlToValidate="nome"
                        Text="Campo obrigatório" 
                        ErrorMessage="Por Favor, informe o nome do cliente" 
                        CssClass="text-danger"
                        Display="Dynamic" 
                        ValidationGroup="formCadastro">
                    </asp:RequiredFieldValidator>
                    <br />
                    <label>E-mail:</label>
                    <asp:TextBox ID="email" CssClass="form-control" type="text" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator 
                        ID="requiredEmail" 
                        runat="server" 
                        ControlToValidate="email"
                        Text="Campo obrigatório" 
                        ErrorMessage="Por Favor, informe o email do cliente" 
                        CssClass="text-danger"
                        Display="Dynamic" 
                        ValidationGroup="formCadastro">
                    </asp:RequiredFieldValidator>
                    <br />
                    
                    <label>Data de Nascimento:</label>
                    <asp:TextBox ID="dtnasc" CssClass="form-control" type="date" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator 
                        ID="requiredDtnasc" 
                        runat="server" 
                        ControlToValidate="dtnasc"
                        Text="Campo obrigatório" 
                        ErrorMessage="Por Favor, informe a data de nascimento do cliente" 
                        CssClass="text-danger"
                        Display="Dynamic" 
                        ValidationGroup="formCadastro">
                    </asp:RequiredFieldValidator>
                    <br />
                <label>Sexo:</label>
                <asp:RadioButtonList ID="rblSexo" runat="server" >                 
                </asp:RadioButtonList>
                    <asp:RequiredFieldValidator 
                        ID="requiredSexo" 
                        runat="server" 
                        ControlToValidate="rblSexo"
                        Text="Campo obrigatório" 
                        ErrorMessage="Por Favor, informe o sexo do cliente" 
                        CssClass="text-danger"
                        Display="Dynamic" 
                        ValidationGroup="formCadastro">
                    </asp:RequiredFieldValidator>
                    <br />
                    <label>Estado Civil:</label>
                <asp:DropDownList ID="ddlEstadoCivil" runat="server" CssClass="form-control">
                        <asp:ListItem Value="" Text="-- Escolha a opção --"></asp:ListItem>
                </asp:DropDownList>
                    <asp:RequiredFieldValidator 
                        ID="requiredEstadoCivil" 
                        runat="server" 
                        ControlToValidate="ddlEstadoCivil"
                        Text="Campo obrigatório" 
                        ErrorMessage="Por Favor, informe o Estado Civil do cliente" 
                        CssClass="text-danger"
                        Display="Dynamic" 
                        ValidationGroup="formCadastro">
                    </asp:RequiredFieldValidator>
                    <br />
                    <div class="text-right">
                    <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar Cliente" CssClass="btn btn-success" OnClick="btnCadastrar_Click" ValidationGroup="formCadastro"/>
                    </div>
                    <br />
                    <br />
                    <asp:Panel ID="painelSucesso" runat="server" Visible="false">
                        <div class="alert alert-success">
                            <asp:Label ID="lblMensagemSucesso" runat="server"></asp:Label>
                        </div>
                    </asp:Panel>
                    <asp:Panel ID="painelErro" runat="server" Visible="false">
                        <div class="alert alert-danger">
                            <asp:Label ID="lblMensagemErro" runat="server"></asp:Label>
                        </div>
                    </asp:Panel>
                    <asp:ValidationSummary
                        ID="ValidationSummary1"
                        runat="server"
                        HeaderText="Erros de validação:"
                        DisplayMode="BulletList"
                        EnableClientScript="true"
                        CssClass="alert alert-danger text-danger"
                        ValidationGroup="formCadastro"
                        />
                </div>

                <div class="col-md-4">
                    
                    
                    
                </div>
            </div>
        </form>
    </div>
</body>
</html>
