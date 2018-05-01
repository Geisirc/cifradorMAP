using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Criptografia.Models
{
    public class Cifra 
    {
        public string textoOriginal { get; set; }
        public string chave { get; set; }

        public ICriptografa comportamento;
        public string textoCifrado {
            get {
                string _retorno = "";

                comportamento = new ComportamentoCriptografiaVigenere();
                _retorno = comportamento.Cripto(this.textoOriginal, this.chave, false);
                return _retorno;
            }
            
            set { }  }

        public bool Validado() {

            bool _retorna = true;

            ICriptografa comportamento = new ComportamentoCriptografiaVigenere();
            if (! comportamento.Valida(this.textoOriginal, this.chave))
            {
                _retorna = false;
            }


            return _retorna;

        }


    }
}