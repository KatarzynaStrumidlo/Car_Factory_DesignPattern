using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarFactory factory = new CarFactory();
            CarShowroom carShowroom = new CarShowroom(factory);
            Console.WriteLine("Welcome in car factory");
            do {
                Console.WriteLine("What kind of client you are?");
                Console.WriteLine("\t 1) Artist");
                Console.WriteLine("\t 2) Rich");
                Console.WriteLine("\t 3) Young");
                int userType = int.Parse(Console.ReadLine());


                switch (userType)
                {
                    case 1:
                        var car = carShowroom.createSpecialCar(new Artist());
                        Console.WriteLine("     *   *   *   *   *");
                        Console.WriteLine("Scpecially for Artist " + car.Type + " car.");
                        Console.WriteLine("     *   *   *   *   *");
                        break;

                    case 2:
                        var car2 = carShowroom.createSpecialCar(new Rich());
                        Console.WriteLine("     *   *   *   *   *");
                        Console.WriteLine("Scpecially for Rich " + car2.Type + " car.");
                        Console.WriteLine("     *   *   *   *   *"); ;
                        break;

                    case 3:
                        var car3 = carShowroom.createSpecialCar(new Young());
                        Console.WriteLine("     *   *   *   *   *");
                        Console.WriteLine("Scpecially for Young " + car3.Type + " car.");
                        Console.WriteLine("     *   *   *   *   *");
                        break;
                }
            } while (true);

            Console.ReadKey();

        }
    }
}
