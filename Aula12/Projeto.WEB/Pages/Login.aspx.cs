using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security; //autenticação..

namespace Projeto.WEB.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        //evento executado quando a página é carregada..
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //evento click do botão..
        protected void btnAcesso_Click(object sender, EventArgs e)
        {
            try
            {
                //resgatar o login e senha informados no formulário..
                string login = txtLogin.Text;
                string senha = txtSenha.Text;

                if(login.Equals("admin") && senha.Equals("admin"))
                {
                    FormsAuthenticationTicket ticket = 
                        new FormsAuthenticationTicket(login, false, 5);

                    HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName,
                                                       FormsAuthentication.Encrypt(ticket));
                    Response.Cookies.Add(cookie); //gravando..

                    //redirecionar..
                    Response.Redirect("/AreaRestrita/Default.aspx");
                }
                else
                {
                    throw new Exception("Acesso Negado. Usuário inválido.");
                }
            }
            catch(Exception ex)
            {
                //imprimir mensagem de erro..
                lblMensagem.Text = ex.Message;
            }
        }
    }
}