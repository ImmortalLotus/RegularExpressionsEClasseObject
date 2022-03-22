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
    }
}
