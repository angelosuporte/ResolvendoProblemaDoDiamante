namespace ProblemaDoDiamante.Devices
{
    abstract class Dispositivo
    {
        public int SerialNumber { get; set; }

        public abstract void ProcessDoc(string documento);
    }

}
