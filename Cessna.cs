using System;

namespace InterfacesIntro
{
    public class Cessna : IVehicle, IGasVehicle
    {
        public int FuelCapacity { get; set; }
        public int FuelLevel { get; set; }

        public void Drive()
        {
            Console.WriteLine("Zoooooom");
        }

        public void RefuelTank()
        {
            FuelLevel = FuelCapacity;
        }
    }
}