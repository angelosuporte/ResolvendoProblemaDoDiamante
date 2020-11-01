﻿using System;

namespace ProblemaDoDiamante.Devices
{
    class Scanner : Dispositivo, IScanner
    {
        public override void ProcessDoc(string documento)
        {
            Console.WriteLine("Scanner processando: " + documento);
        }

        public string Scan()
        {
            return "Scanner scan resultado: OK ";
        }
    }
}
