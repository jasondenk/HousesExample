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

        public void Paint(string color)
        {
            this.color = color;
        }

        public string CurrentColor()
        {
            return color;
        }
    }
}
