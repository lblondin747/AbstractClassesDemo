using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string year { get; set; } = "1900";
        public string make { get; set; } = "Generic Make";
        public string model { get; set; } = "Generic Model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Im driving a vehicle.");
        }
    }
}
