namespace P01_RawData
{
    public class Cargo
    {
        public Cargo(int cargoWeight, string cargoType)
        {
            this.Weight = cargoWeight;
            this.Type = cargoType;
        }
        public string Type { get; private set; }
        public int Weight { get; private set; }
    }
}

