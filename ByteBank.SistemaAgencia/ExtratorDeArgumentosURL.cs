using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorDeArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get;}
        public ExtratorDeArgumentosURL(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("A url não pode ser nem nula, nem vazia.", nameof(url));               
            }
            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);
            URL = url;
        }

        public string GetValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper();
            string argumentosEmCaixaAlta = _argumentos.ToUpper();

            string argumento = nomeParametro + "=";
            //Porque se vier só 'nome', e for buscar na url e ela for:
            //www.blabla.com/cadastro?email=nome&nome=ze, vai acontecer um negócio esquisito
            int indiceArg = argumentosEmCaixaAlta.IndexOf(argumento);
            //basicamente pega o index dá última letra de um texto, existe porque
            //é o jeito mais 'eficiente' de automatizar isso.
            //O que acontece é que ele procura dentro de _argumentos o texto argumento e pega o índex de onde isso começa.
            string resultado = argumentosEmCaixaAlta.Substring(indiceArg + argumento.Length);
            int indexEComercio = resultado.IndexOf('&');

            if (indexEComercio == -1)
                return resultado;

            return resultado.Remove(indexEComercio);
        }
    }
}
