using System;

namespace ProblemaDoDiamante.Devices
{
    class DispositivoCombo : Dispositivo, IScanner, IImpressora
    {
        public void Imprimir(string documento)
        {
            Console.WriteLine("DispositivoCombo imprimindo: " + documento);
        }

        public override void ProcessDoc(string documento)
        {
            Console.WriteLine("DispositivoCombo processando: " + documento);
        }

        
        public string Scan()
        {
            return "Resultado do Scan do DispositivoCombo: OK";
        }
    }
}
