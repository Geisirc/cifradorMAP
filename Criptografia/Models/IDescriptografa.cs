using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Criptografia.Models
{
    public interface IDescriptografa
    {
        string Cripto(string mensagem, string chave, bool ignoraEspeciais = true);

        bool Valida(string mensagem, string chave);

    }
}