using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projeto.Entidades.Tipos;
using Projeto.Entidades;
using Projeto.BLL;


namespace Projeto.WEB.Clientes
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                CarregarSexo();
                CarregarEstadoCivil();
            }
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            painelSucesso.Visible = false;
            painelErro.Visible = false;

            try
            {
                Cliente c = new Cliente();
                c.Nome = nome.Text;
                c.Email = email.Text;
                c.DataNascimento = DateTime.Parse(dtnasc.Text);
                c.Sexo = (Sexo)Enum.Parse(typeof(Sexo), rblSexo.SelectedValue);
                c.EstadoCivil = (EstadoCivil)Enum.Parse(typeof(EstadoCivil), ddlEstadoCivil.SelectedValue);

                ClienteBusiness business = new ClienteBusiness();
                business.Cadastrar(c);

                painelSucesso.Visible = true;
                lblMensagemSucesso.Text = $"Cliente {c.Nome}, cadastrado com sucesso.";

                LimparCampos();
            }
            catch (Exception ex)
            {
                painelErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }  
        }

        private void LimparCampos()
        {
            nome.Text = string.Empty;
            email.Text = string.Empty;
            dtnasc.Text = string.Empty;
            rblSexo.SelectedIndex = -1;
            ddlEstadoCivil.SelectedIndex = 0;
        }
        
        private void CarregarSexo()
        {
            rblSexo.DataSource = Enum.GetNames(typeof(Sexo));
            rblSexo.DataBind();
        }
        
        private void CarregarEstadoCivil()
        {
            ddlEstadoCivil.DataSource = Enum.GetNames(typeof(EstadoCivil));
            ddlEstadoCivil.DataBind();

            ListItem item = new ListItem("- Escolha uma Opção -", "");
            ddlEstadoCivil.Items.Insert(0, item);
        }
    }
}