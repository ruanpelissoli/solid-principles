using solid_principles.ISP.Solution;

namespace solid_principles.ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            var multifuncional = new MultifunctionPrinter();
            multifuncional.Print();
            multifuncional.Scanner();
            multifuncional.SendFax();

            var impressora = new Pinter();
            impressora.Print();
        }
    }
}
