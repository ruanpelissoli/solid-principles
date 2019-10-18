using System;

namespace solid_principles.ISP.Solution
{
    public class Impressora : IImprimir
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimir");
        }
    }
}
