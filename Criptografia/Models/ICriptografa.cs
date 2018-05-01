using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografia.Models
{
    public interface ICriptografa
    {

        string Cripto(string mensagem, string chave, bool ignoraEspeciais = true);

        bool Valida(string mensagem, string chave);

    }
}
