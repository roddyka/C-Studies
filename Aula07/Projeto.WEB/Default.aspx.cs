using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto.WEB
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAcesso_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ddlOpcao.SelectedValue))
            {
                int opcao = int.Parse(ddlOpcao.SelectedValue);

                switch (opcao)
                {
                    case 1:
                        Response.Redirect("/Clientes/Cadastro.aspx");
                        break;
                    case 2:
                        Response.Redirect("/Clientes/Consulta.aspx");
                        break;
                }
            }
            else
            {
                lblMensagem.Text = "Por favor selecione uma opção!";
            }
        }
    }
}