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
    public partial class Edicao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarEstadoCivil();
                CarregarSexo();
                CarregarDados();
            }
        }

        protected void btnEdicao_Click(object sender, EventArgs e)
        {
            painelSucesso.Visible = false;
            painelErro.Visible = false;

            try
            {
                Cliente c = new Cliente();
                c.IdCliente = int.Parse(txtCodigo.Value);
                c.Nome = nome.Text;
                c.DataNascimento = DateTime.Parse(dtnasc.Text);
                c.Sexo = (Sexo)Enum.Parse(typeof(Sexo), rblSexo.SelectedValue);
                c.EstadoCivil = (EstadoCivil)Enum.Parse(typeof(EstadoCivil), ddlEstadoCivil.SelectedValue);

                ClienteBusiness business = new ClienteBusiness();
                business.Atualizar(c); //atualizando

                painelSucesso.Visible = true;
                lblMensagemSucesso.Text = $"Cliente {c.Nome}, atualizado com sucesso.";

            }
            catch (Exception ex)
            {
                painelErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
        }

        private void CarregarDados()
        {
            try
            {
                int idCliente = int.Parse(Request.QueryString["id"]);

                ClienteBusiness business = new ClienteBusiness();
                Cliente c = business.ObterPorId(idCliente);

                txtCodigo.Value = c.IdCliente.ToString();
                nome.Text = c.Nome;
                email.Text = c.Email;
                dtnasc.Text = c.DataNascimento.ToString("yyyy-MM-dd");
                rblSexo.SelectedValue = c.Sexo.ToString();
                ddlEstadoCivil.Text = c.EstadoCivil.ToString();

            }
            catch (Exception e)
            {
                painelErro.Visible = true;
                lblMensagemErro.Text = e.Message;
            }
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