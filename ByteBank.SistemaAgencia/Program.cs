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
        }
    }
}
