using ByteBank.Modelos;
using System;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ContaCorrente conta = new ContaCorrente(12,12);
            string url ="pagina?argumentos";
            string argumentos = url.Substring(6);
            //Anotando lógica de regex para pegar um número de telefone
            // [0-9]{4}[-][0-9]{4}
            // o {} é como se fosse um vezes,
            // o que tá dentro do colchete é a regra,
            // e o traço sozinho é o caracter traço
            // [0-9]{4,5}[-][0-9]{4}
            // a vírgula quer dizer que quer de x, até y
            // [0-9]{4,5}[-]{0,1}[0-9]{4}
            // e se o cara não colocar o hífen? ^
            // [0-9]{4,5}-{0,1}[0-9]{4}
            // o hífen não precisa de colchete ^
            // [0-9]{4,5}-?[0-9]{4}
            // o {0,1}, ou seja, o pode não ter, pode ser trocado por: um '?'
            // Regex.IsMatch - retorna sempre true ou false
            // Regex.Match retorna a string que deu match dentro da outra string.
        }
    }
}
