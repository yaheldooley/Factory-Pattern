namespace FactoryPattern
{
	public partial class Program
    {
		public class Car : IVehicle
		{
			public Car()
			{
				Drive();
			}
			public void Drive()
			{
				Console.WriteLine("Building a new Car!");
			}
			public int Wheels { get; set; }
		}
            



    }
}
