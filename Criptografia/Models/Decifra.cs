using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Criptografia.Models
{
    public class Decifra
    {
        public string textoCifrado { get; set; }
        public string chave { get; set; }

        public IDescriptografa comportamento;
        public string textoOriginal
        {
            get
            {
                string _retorno = "";

                comportamento = new ComportamentoDescriptografiaVigenere();
                _retorno = comportamento.Cripto(this.textoCifrado, this.chave, false);
                return _retorno;
            }

            set { }
        }

        public bool Validado()
        {

            bool _retorna = true;

            IDescriptografa comportamento = new ComportamentoDescriptografiaVigenere();
            if (!comportamento.Valida(this.textoCifrado, this.chave))
            {
                _retorna = false;
            }


            return _retorna;

        }

    }
}