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
                    <p><asp:Label ID="lblMensagem" runat="server"></asp:Label></p>
                    <asp:GridView ID="gridClientes" runat="server" GridLines="None" CssClass="table table-hover" AutoGenerateColumns="false" 
                        AllowPaging="true" PageSize="5" OnPageIndexChanging="gridClientes_PageIndexChanging">
                        <PagerSettings
                    NextPageText="   Próxima >"
                    PreviousPageText="< Anterior   "
                    Mode="NextPrevious"
                    
                 />
                        <Columns>                          
                            <asp:TemplateField HeaderText="Nome do Cliente">
                                <ItemTemplate>
                                    <%# Eval("Nome") %>
                                </ItemTemplate>
                            </asp:TemplateField>

                             <asp:TemplateField HeaderText="Endereço de Email">
                                <ItemTemplate>
                                    <%# Eval("Email") %>
                                </ItemTemplate>
                            </asp:TemplateField>

                             <asp:TemplateField HeaderText="Data de Nascimento">
                                <ItemTemplate>
                                    <%# Eval("DataNascimento", "{0:dd/MM/yyyy}") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            
                             <asp:TemplateField HeaderText="Sexo">
                                <ItemTemplate>
                                    <%# Eval("Sexo") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            
                             <asp:TemplateField HeaderText="Estado Civil">
                                <ItemTemplate>
                                    <%# Eval("EstadoCivil") %>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Operações">
                                <ItemTemplate>
                                   <a href="Exclusao.aspx?id=<%# Eval("IdCliente") %>" class="btn btn-danger btn-sm">Excluir</a>
                                    <a href="Edicao.aspx?id=<%# Eval("IdCliente") %>" class="btn btn-primary btn-sm">Atualizar</a>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </form>
    </div>
</body>
</html>
