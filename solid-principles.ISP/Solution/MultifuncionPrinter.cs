﻿using System;

namespace solid_principles.ISP.Solution
{
    public class MultifuncionPrinter : IPrint, IScanner, ISendFax
    {
        public void Print()
        {
            Console.WriteLine("Print");
        }

        public void Scanner()
        {
            Console.WriteLine("Scanner");
        }

        public void SendFax()
        {
            Console.WriteLine("Send Fax");
        }
    }
}
