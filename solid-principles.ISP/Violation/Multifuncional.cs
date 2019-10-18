using System;

namespace solid_principles.ISP.Violation
{
    public class Multifuncional : IImpressora
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
