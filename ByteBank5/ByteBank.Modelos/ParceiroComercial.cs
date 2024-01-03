using Bytebank.Sistemas;
using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank
{
    public class ParceiroComercial : Autenticavel
    {
        private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();

        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return _autenticacaoHelper.CompararSenhas(Senha, senha);
        }
        

    }
}
