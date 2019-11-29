using System;
using UValueCalculator;
using UValueCalculator.UValueComponents;
using Xunit;

namespace TestUValueCalculator
{
    public class WindowTests
    {
        private readonly Material glass = new Material("Glass", 0.91);
        private readonly Material aluminium = new Material("Aluminium", 0.61);

        [Fact]
        public void SimpleWindowUValueTest()
        {
            Panel panel = new Panel(10, 10);
            panel.AddLayer(glass, 5);

            Frame frame = new Frame(15, 15, 5);
            frame.AddLayer(aluminium, 5);

            WindowSeal seal = new WindowSeal(panel, 3);

            Window window = new Window(panel, frame, seal);

            Assert.Equal(0.682, window.CalculateUValue(), 3);
        }

        [Fact]
        public void MissingFrameThrowsExceptionTest()
        {
            Panel panel = new Panel(10, 10);
            panel.AddLayer(glass, 5);
            WindowSeal seal = new WindowSeal(panel, 3);

            Window window = new Window();
            window.Panel = panel;
            window.Seal = seal;

            Assert.False(window.IsValid);

            var ex = Assert.Throws<ArgumentException>(() =>
            {
                window.CalculateUValue();
            });
        }

        [Fact]
        public void MissingPanelThrowsExceptionTest()
        {
            Panel panel = new Panel(10, 10);
            Frame frame = new Frame(15, 15, 5);
            frame.AddLayer(aluminium, 5);
            WindowSeal seal = new WindowSeal(panel, 3);

            Window window = new Window();
            window.Frame = frame;
            window.Seal = seal;

            Assert.False(window.IsValid);

            var ex = Assert.Throws<ArgumentException>(() =>
            {
                window.CalculateUValue();
            });
        }
    }
}