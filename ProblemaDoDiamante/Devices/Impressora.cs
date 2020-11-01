using System;

namespace ProblemaDoDiamante.Devices
{
    class Impressora : Dispositivo, IImpressora
    {
        public override void ProcessDoc(string documento)
        {
            Console.WriteLine("Impressora processando: " + documento);
        }

        public void Imprimir(string documento)
        {
            Console.WriteLine("Impressora imprimindo: " + documento);
        }
    }
}
