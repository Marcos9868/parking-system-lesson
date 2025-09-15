using System.Text;
using ParkingSystem.Models;

Console.OutputEncoding = Encoding.UTF8;

decimal initialPrice;
decimal hourPrice;

System.Console.WriteLine("Welcome to parking system of Codetech Software Solutions!\n Type initial price: ");
initialPrice = Convert.ToDecimal(Console.ReadLine());

System.Console.WriteLine("Now, type hour price: ");
hourPrice = Convert.ToDecimal(Console.ReadLine());

Parking parking = new Parking(initPrice: initialPrice, hourPrice: hourPrice);
string option = string.Empty;

bool showMenu = true;
while (showMenu)
{
  Console.Clear();
  System.Console.WriteLine("Type your option: ");
  System.Console.WriteLine("1 - Add Vehicle");
  System.Console.WriteLine("2 - Remove Vehicle");
  System.Console.WriteLine("3 - List Vehicles");
  System.Console.WriteLine("4 - Exit");
  option = Console.ReadLine();
  switch (option)
  {
    case "1":
      parking.AddVehicle();
      break;
    case "2":
      parking.RemoveVehicle();
      break;
    case "3":
      parking.ListVehicles();
      break;
    case "4":
      showMenu = false;
      break;
    default:
      System.Console.WriteLine("Invalid Option");
      break;
  }
  System.Console.WriteLine("Type any key to continue");
  Console.ReadLine();
}
System.Console.WriteLine("System was ended");