﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.BLL.Excecoes.Usuarios
{
    public class MenorDeIdadeException:Exception
    {
        public override string Message
        {
            get
            {
                return "O usuario não pode ser menor de 18 anos";
            }
        }

    }
}
