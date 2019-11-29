namespace UValueCalculator.UValueComponents
{
    public class WindowSeal
    {
        public double Length { get; set; }

        public double TransferCoefficent { get; set; }

        public WindowSeal(Panel panel, double transferCoefficent)
        {
            Length = (2 * panel.Width) + (2 * panel.Height);
            TransferCoefficent = transferCoefficent;
        }
    }
}