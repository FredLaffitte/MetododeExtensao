using System;

namespace MetododeExtensao
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Looke A MelhOR plataforma de strEAMing de FILMES do Mundo.";

            Console.WriteLine("===========================================================");
            Console.WriteLine("=Alterando as letras maiúsculas e minúsculas de uma string=");
            Console.WriteLine("===========================================================");
            Console.WriteLine($"Antes de inverter..: {texto}");
            Console.WriteLine($"Depois de invertido: {texto.InverteCase()}");
            Console.ReadLine();
        }
    }
}
