using System;

namespace solid_principles.ISP.Solution
{
    public class Multifuncional : IImprimir, IDigitalizar, IEnviarFax
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimir");
        }

        public void Digitalizar()
        {
            Console.WriteLine("Digitalizar");
        }

        public void EnviarFax()
        {
            Console.WriteLine("Enviar fax");
        }
    }
}
