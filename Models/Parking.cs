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
            if (!string.IsNullOrEmpty(plate))
                _vehicles.Add(plate);
        }
        public void RemoveVehicle()
        {
            System.Console.WriteLine("Type vehicle plate to remove: ");
            string plate = Console.ReadLine();
            if (_vehicles.Any(v => v.ToUpper() == plate.ToUpper()))
            {
                int hoursQuantity = 0;
                System.Console.WriteLine("");
                string hours = Console.ReadLine();
                decimal totalCostVehicle = _initPrice + _hourPrice * hoursQuantity;
                if (!string.IsNullOrEmpty(plate))
                {
                    _vehicles.Remove(plate);
                    System.Console.WriteLine("Vehicle removed successfully");

                }
                else
                {
                    System.Console.WriteLine("Unable to remove vehicle");
                }
            }
        }
        public void ListVehicles()
        {
            if (_vehicles.Count > 0)
            {
                System.Console.WriteLine("List of parking vehicles: ");
                foreach (var vehicle in _vehicles)
                {
                    System.Console.WriteLine($"{vehicle}");
                }
            }
            else
            {
                System.Console.WriteLine("Do not have any vehicle parked here");
            }
        }
    }
}