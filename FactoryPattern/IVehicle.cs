namespace FactoryPattern
{
	public partial class Program
    {
		public interface IVehicle
        {
			public void Drive();
			public int Wheels { get; set; }
        }
            



    }
}
