using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }
        public bool HasSidecart { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine("Driving my motorcycle(Abstract)");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Driving my motorcycle(Virtual)");
        }
    }
}
