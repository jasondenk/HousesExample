using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousesExample
{
    class House
    {
        private string color;
        private int rooms;
        private int size;
        private int doors;

        public House(string color, int rooms, int size, int doors)
        {
            this.color = color;
            this.rooms = rooms;
            this.size = size;
            this.doors = doors;
        }

        public House(string color, int rooms, int size)
        {
            this.color = color;
            this.rooms = rooms;
            this.size = size;            
        }

        public House(string color, int size)
        {
            this.color = color;
            this.size = size;
        }

        public House(int rooms, int size)
        {
            this.rooms = rooms;
            this.size = size;
        }

        public House()
        {
            this.color = "Grey";
            this.rooms = 1;
            this.size = 300;
            this.doors = 1;
        }

        public void Paint(string color)
        {
            this.color = color;
        }

        public string CurrentColor()
        {
            return color;
        }
        
        public void DisplayHouseInfo()
        {
            Console.WriteLine("House Color: " + color + ", # of Rooms: " + rooms + ", Square feet: " + size + ", # of Doors:" + doors + ".");
        }
    }
}
