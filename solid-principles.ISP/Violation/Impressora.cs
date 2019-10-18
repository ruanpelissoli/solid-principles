using System;

namespace solid_principles.ISP.Violation
{
    public class Impressora : IImpressora
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimir");
        }

        public void Digitalizar()
        {
            throw new NotImplementedException();
        }

        public void EnviarFax()
        {
            throw new NotImplementedException();
        }
    }
}
