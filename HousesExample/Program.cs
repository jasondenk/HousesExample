using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            House house1 = new House("Green",4,1000,3);
            House house2 = new House("Blue", 5, 800);
            House house3 = new House("Red", 1500);
            House house4 = new House(4, 900);
            House house5 = new House();

            Console.WriteLine("House 1:");            
            house1.DisplayHouseInfo();
            Console.WriteLine("House 2:");
            house2.DisplayHouseInfo();
            Console.WriteLine("House 3:");
            house3.DisplayHouseInfo();
            Console.WriteLine("House 4:");
            house4.DisplayHouseInfo();
            Console.WriteLine("House 5:");
            house5.DisplayHouseInfo();

            house2.Paint("Yellow");
            Console.WriteLine("House 2:");
            house2.DisplayHouseInfo();

            house2.Name = "Denk House";
            Console.WriteLine(house2.Name);
            house2.Name = "Blue House";
            Console.WriteLine(house2.Name);




            /*house1.Paint("Green");
            house1.NumberOfRooms(4);
            house1.SetSize(1000);
            house1.NumberOfDoors(3);*/
            Console.WriteLine("\nType any key to exit.");
            Console.ReadKey();
        }
    }
}
