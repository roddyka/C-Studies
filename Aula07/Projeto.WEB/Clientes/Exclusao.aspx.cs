using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projeto.Entidades;
using Projeto.BLL;

namespace Projeto.WEB.Clientes
{
    public partial class Exclusao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarDados();
            }
        }

        private void CarregarDados()
        {
            try
            {
                //resgatando id enviado pela url
                int idCliente = int.Parse(Request.QueryString["id"]);

                //buscando o cliente pelo id
                ClienteBusiness business = new ClienteBusiness();
                Cliente c = business.ObterPorId(idCliente);

                txtCodigo.Value = c.IdCliente.ToString();
                lblNome.Text = c.Nome;
                lblEmail.Text = c.Email;
                lblDatanascimento.Text = c.DataNascimento.ToString("dd/MM/yyyy");
                lblSexo.Text = c.Sexo.ToString();
                lblEstadoCivil.Text = c.EstadoCivil.ToString();
            }
            catch (Exception e)
            {
                lblMensagem.Text = e.Message;
            }
        }

        protected void btnExclusao_Click(object sender, EventArgs e)
        {
            try
            {
                int idCliente = int.Parse(txtCodigo.Value);
                ClienteBusiness business = new ClienteBusiness();
                business.Excluir(idCliente);

                lblMensagem.Text = "Cliente excluido com sucesso.";
                painelExclusao.Visible = false;

            }
            catch(Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}