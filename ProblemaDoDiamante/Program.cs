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
            Console.WriteLine();

            Scanner scanner = new Scanner() { SerialNumber = 2003 };
            scanner.ProcessDoc("Meu e-mail");
            Console.WriteLine(scanner.Scan());
            Console.WriteLine();
            Console.WriteLine();

            DispositivoCombo dispositivoCombo = new DispositivoCombo() { SerialNumber = 3921 };
            dispositivoCombo.ProcessDoc("Relatório da solução de problema do diamante");
            dispositivoCombo.Imprimir("Relatório da solução do problema do diamante");
            Console.WriteLine(dispositivoCombo.Scan());

            Console.ReadKey();
        }
    }
}
