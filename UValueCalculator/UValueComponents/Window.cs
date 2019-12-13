using System;

namespace UValueCalculator.UValueComponents
{
    public class Window : IUValueComponent
    {
        public string Name { get; set; }

        public double SurfaceArea
        {
            get
            {
                return Panel.SurfaceArea + Frame.SurfaceArea;
            }
        }

        public Panel Panel { get; set; }

        public Frame Frame { get; set; }

        public WindowSeal Seal { get; set; }

        public bool IsValid
        {
            get
            {
                return Panel != null && Frame != null && Seal != null;
            }
        }

        public Window()
        {
            Name = "Untitled Window";
        }

        public Window(Panel panel, Frame frame, WindowSeal seal) : this("Untitled Window", panel, frame, seal)
        {
        }

        public Window(string name, Panel panel, Frame frame, WindowSeal seal)
        {
            Name = name;
            Panel = panel;
            Frame = frame;
            Seal = seal;
        }

        public double CalculateUValue()
        {
            if (!IsValid) throw new ArgumentException("Invalid window configuration. Missing frame, panel or seal.");
            return ((Panel.SurfaceArea * Panel.CalculateUValue()) + (Frame.SurfaceArea * Frame.CalculateUValue()) + (Seal.Length * Seal.TransferCoefficent))
                / (Panel.SurfaceArea + Frame.SurfaceArea);
        }
    }
}