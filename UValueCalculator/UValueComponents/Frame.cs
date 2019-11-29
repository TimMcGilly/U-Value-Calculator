namespace UValueCalculator.UValueComponents
{
    public class Frame : SimpleUValueComponent
    {
        public double OuterWidth { get; set; }

        public double OuterHeight { get; set; }

        public double FrameThickness { get; set; }

        new public double SurfaceArea
        {
            get
            {
                double outerArea = OuterHeight * OuterWidth;
                double innerArea = (OuterHeight - FrameThickness) * (OuterWidth - FrameThickness);
                return outerArea - innerArea;
            }
        }

        public Frame(double outerWidth, double outerHeight, double frameThickness)
        {
            OuterWidth = outerWidth;
            OuterHeight = outerHeight;
            FrameThickness = frameThickness;
        }
    }
}