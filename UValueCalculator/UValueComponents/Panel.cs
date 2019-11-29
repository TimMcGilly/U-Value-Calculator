namespace UValueCalculator.UValueComponents
{
    public class Panel : SimpleUValueComponent
    {
        public double Width { get; set; }
        public double Height { get; set; }

        new public double SurfaceArea
        {
            get { return Width * Height; }
        }

        public Panel(double width, double height)
        {
            Width = width;
            Height = height;
        }
    }
}