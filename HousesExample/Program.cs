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

            Console.WriteLine("House 1:");            
            house1.DisplayHouseInfo();
            Console.WriteLine("House 2:");
            house2.DisplayHouseInfo();

            /*house1.Paint("Green");
            house1.NumberOfRooms(4);
            house1.SetSize(1000);
            house1.NumberOfDoors(3);*/
            Console.WriteLine("\nType any key to exit.");
            Console.ReadKey();
        }
    }
}
