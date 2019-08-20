using System;

namespace solid_principles.LSP.Solution
{
    public class Square : Shape
    {
        public Square(int width, int height) : base(width, height)
        {
            if (width != height)
                throw new ArgumentException("Invalid square.");
        }
    }
}
