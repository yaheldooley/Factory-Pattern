namespace FactoryPattern
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var car = VehicleFactory.GetVehicle();   
            }
        }
            



    }
}
