namespace FactoryPattern
{
	public partial class Program
    {
		public static class VehicleFactory
        {
            public static IVehicle GetVehicle()
            {
				Console.WriteLine("Entering the Vehicle Factory!\n\n");
				int wheelCount = 0;
                while (true)
                {
                    
                    Console.WriteLine("Enter the amount of wheels (2 - 4) for the vehicle you would like to build...");
                    var input = Console.ReadLine();
                    int wheels;
                    if ( int.TryParse(input, out wheels) && wheels > 1 && wheels < 5 )
                    {
						wheelCount = wheels;
                        break;
					}
                }
                switch (wheelCount)
                {
                    case 2:
                        return new MotorCycle();
                    case 3:
                        return new MotorCycleWithSideCar();
                    case 4:
                        return new Car();
                    default:
                        return null;
                }
            }
        }
            



    }
}
