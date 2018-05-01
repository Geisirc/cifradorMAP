using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Criptografia.Models
{
    public class Biblioteca
    {
        static public char Chr(int codigo)
        {
            return (char)codigo;
        }

        static public int Asc(string letra)
        {
            return (int)(Convert.ToChar(letra));
        }


        static public string RetornaAlfabetoDoNivel(string letra)
        {
            string _retorno = "";
            string alfabetoBase = "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ";

            int Nivel = Asc(letra)-65;

            _retorno = alfabetoBase.Substring(Nivel, 26);

            return _retorno;
        }

        public static string CifraVigenere(string mensagem, string chave, bool ignoraEspeciais = true)
        {
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
                    }else
                    {
                        codigo += (char)mensagem[i];
                    }
                    continue;
                }
                codigo += (char)((c + char.ToUpper(chave[j % chave.Length]) - 2 * 'A') % 26 + 'A');
            }
            return codigo;
        }


        public static string Decifra(string cifra, string chave, bool ignoraEspeciais = true)
        {
            var mensagem = "";
            string letra = "";
            for (int i = 0; i < cifra.Length; i++)
            {
                letra = Convert.ToString(cifra[i]);
                if (letra == " ")
                {
                    mensagem += " ";
                    continue;
                }
                char c = char.ToUpper(cifra[i]);
                if (c < 'A' || c > 'Z')
                {
                    if (ignoraEspeciais)
                    {
                        mensagem += " ";
                    } else
                    {
                        mensagem += cifra[i];
                    }
                    continue;
                }
                char cha = char.ToUpper(chave[i % chave.Length]);
                mensagem += (char)((26 - (cha % 65 - c % 65)) % 26 + 65);
            }

            return mensagem;
        }

    }
}