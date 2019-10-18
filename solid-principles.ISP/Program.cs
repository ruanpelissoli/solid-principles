using solid_principles.ISP.Solution;

namespace solid_principles.ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            var multifuncional = new Multifuncional();
            multifuncional.Imprimir();
            multifuncional.Digitalizar();
            multifuncional.EnviarFax();

            var impressoira = new Impressora();
            impressoira.Imprimir();
        }
    }
}
