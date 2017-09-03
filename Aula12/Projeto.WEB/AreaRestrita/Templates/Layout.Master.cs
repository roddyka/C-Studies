using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security; //autenticação..

namespace Projeto.WEB.AreaRestrita.Templates
{
    public partial class Layout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //evento do botão..
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //destruir o ticket de acesso..
            FormsAuthentication.SignOut();

            //redirecionar para a página de autenticação
            //que foi mapeada no \Web.config.xml
            FormsAuthentication.RedirectToLoginPage();
        }
    }
}