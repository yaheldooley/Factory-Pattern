namespace FactoryPattern
{
	public partial class Program
    {
		public class MotorCycleWithSideCar : IVehicle
		{
			public MotorCycleWithSideCar()
			{
				Drive();
			}
			public void Drive()
			{
				Console.WriteLine("Building a new Motorcycle with a sidecar!");
			}
			public int Wheels { get; set; }
		}
            



    }
}
