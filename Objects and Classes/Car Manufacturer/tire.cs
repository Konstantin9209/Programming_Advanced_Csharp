namespace CarManufacturer
{
    public class Tire
    {
        public int Year { get; private set; }
        public double Pressure { get; private set; }

        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }
    }
}
