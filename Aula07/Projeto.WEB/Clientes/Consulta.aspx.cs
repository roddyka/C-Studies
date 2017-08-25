using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projeto.BLL;
using Projeto.Entidades;

namespace Projeto.WEB.Clientes
{
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarClientes();
            }
        }

        private void CarregarClientes()
        {
            try
            {
                ClienteBusiness business = new ClienteBusiness();
                List<Cliente> lista = business.Consultar();

                lblMensagem.Text = $"Quantidade de Clientes: {lista.Count}";

                //popular o grid view com os dados da lista
                gridClientes.DataSource = lista; //preenchendo
                gridClientes.DataBind(); //exibir os dados
            }
            catch (Exception ex)
            {
                //exibindo mensagem de error
                lblMensagem.Text = ex.Message;
            }
        }

        protected void gridClientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridClientes.PageIndex = e.NewPageIndex;
            CarregarClientes();
        }
    }
}