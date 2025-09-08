namespace ParkingSystem.Models
{
    public class Parking
    {
        private decimal _initPrice = 0;
        private decimal _hourPrice = 0;
        private List<string> _vehicles = new List<string>();
        public Parking(decimal initPrice, decimal hourPrice)
        {
            _hourPrice = hourPrice;
            _initPrice = initPrice;
        }
        public void AddVehicle()
        {
            System.Console.WriteLine("Type vehicle plate to park: ");
            string plate = Console.ReadLine();
        }
        public void RemoveVehicle()
        { }
        public void ListVehicles()
        {}
    }
}