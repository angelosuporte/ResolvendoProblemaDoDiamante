using System;
using ProblemaDoDiamante.Devices;

namespace ProblemaDoDiamante
{
    class Program
    {
        static void Main(string[] args)
        {
            Impressora impressora = new Impressora() { SerialNumber = 1080 };
            impressora.ProcessDoc("Minha impressão");
            impressora.Imprimir("Minha impressão");

            Scanner scanner = new Scanner() { SerialNumber = 2003 };
            scanner.ProcessDoc("Meu e-mail");
            Console.WriteLine(scanner.Scan());

        }
    }
}
