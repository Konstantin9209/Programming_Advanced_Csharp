namespace CarManufacturer
{
    public class Engine
    {
        public int HorsePower { get; private set; }
        public double CubicCapacity { get; private set; }

        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }
    }
}
