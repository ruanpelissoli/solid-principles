namespace solid_principles.LSP.Solution
{
    public abstract class Shape
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        protected Shape(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea () { return Width * Height; }
    }
}
