using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Criptografia.Models
{
    public class ComportamentoCriptografia : ICriptografa
    {
        public string Cripto(string mensagem, string chave, bool ignoraEspeciais = true)
        {
            if (mensagem=="" || mensagem==null) { return ""; }
            var codigo = "";
            string letra = "";
            for (int i = 0, j = 0; i < mensagem.Length; i++, j++)
            {
                letra = Convert.ToString(mensagem[i]);
                if (letra == " ")
                {
                    codigo += " ";
                    continue;
                }


                char c = char.ToUpper(mensagem[i]);
                if (c < 'A' || c > 'Z')
                {
                    if (ignoraEspeciais)
                    {
                        codigo += " ";
                    }
                    else
                    {
                        codigo += (char)mensagem[i];
                    }
                    continue;
                }
                codigo += (char)((c + char.ToUpper(chave[j % chave.Length]) - 2 * 'A') % 26 + 'A');
            }
            return codigo;

        }

        public bool Valida(string mensagem, string chave)
        {

            bool _retorna = true;

            if (mensagem == "" || mensagem == null)
            {
                _retorna = false;
                throw new Exception("Texto original não especificado!");
            }

            if (chave == "" || chave == null)
            {
                _retorna = false;
                throw new Exception("Chave não especificada!");
            }


            return _retorna;
        }

    }

}