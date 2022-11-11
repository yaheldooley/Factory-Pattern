namespace FactoryPattern
{
	public partial class Program
    {
		public class MotorCycle : IVehicle
        {
            public MotorCycle()
            {
                Drive();
            }
            public void Drive()
            {
                Console.WriteLine("Building a new Motorcycle!");

			}
            public int Wheels { get; set; }
        }
            



    }
}
