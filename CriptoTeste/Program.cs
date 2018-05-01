using Criptografia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptoTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensagemOriginal = "A sua missão é interceptar o objetivo!";
            string chave = "sincero";
            string chave2 = "SINCERO";
            string mensagemCifrada = "";
            string mensagemDecifrada = "";

            ICriptografa compCifra = new ComportamentoCriptografia();
            IDescriptografa compDecifra = new ComportamentoDescriptografia();


            mensagemCifrada = compCifra.Cripto(mensagemOriginal.ToUpper(), chave, false);

            mensagemDecifrada = compDecifra.Cripto(mensagemCifrada, chave2, false);

            Console.WriteLine("Mensagem Original: {0}",mensagemOriginal);
            Console.WriteLine("Chave: {0}", chave);
            Console.WriteLine("Mensagem Cifrada: {0}", mensagemCifrada);
            Console.WriteLine("Mensagem Decifrada: {0}", mensagemDecifrada);



        }
    }
}
