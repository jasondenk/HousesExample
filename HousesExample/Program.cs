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
            House house1 = new House("Green",3,1000,3);

            Console.WriteLine(house1.CurrentColor());
            
            /*house1.Paint("Green");
            house1.NumberOfRooms(4);
            house1.SetSize(1000);
            house1.NumberOfDoors(3);*/
        }
    }
}
