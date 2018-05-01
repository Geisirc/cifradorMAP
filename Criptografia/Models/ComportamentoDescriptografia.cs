using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Criptografia.Models
{
    public class ComportamentoDescriptografia : IDescriptografa
    {
        public string Cripto(string mensagem, string chave, bool ignoraEspeciais = true)
        {
            if (mensagem == "" || mensagem == null) { return ""; }
            var codigo = "";
            string letra = "";
            for (int i = 0; i < mensagem.Length; i++)
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
                        codigo += mensagem[i];
                    }
                    continue;
                }
                char cha = char.ToUpper(chave[i % chave.Length]);
                codigo += (char)((26 - (cha % 65 - c % 65)) % 26 + 65);
            }

            return codigo;

        }
        public bool Valida(string mensagem, string chave)
        {

            bool _retorna = true;

            if (mensagem == "" || mensagem == null)
            {
                _retorna = false;
                throw new Exception("Texto Cifrado não especificado!");
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