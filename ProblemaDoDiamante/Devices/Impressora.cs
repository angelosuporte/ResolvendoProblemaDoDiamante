using System;

namespace ProblemaDoDiamante.Devices
{
    class Impressora : Dispositivo
    {
        public override void ProcessDoc(string documento)
        {
            Console.WriteLine("Impressora processando: " + documento);
        }

        public void Imprimir(string documento)
        {
            Console.WriteLine("Impressora print " + documento);
        }
    }
}
