using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicios
{
    class TilePrice
    {
        // Find Cost of Tile to Cover W x H Floor
        // Calculate the total cost of tile it would take to cover a floor plan of width and height, using a cost entered by the user.
        // Current State: Complete
        public void Run()
        {
            Console.WriteLine("Running {0}",GetType().Name);
            int height;
            int width;
            int price;
            Console.WriteLine("Type the price");
            string prices = Console.ReadLine();
            Console.WriteLine("Type the height");
            string heights = Console.ReadLine();
            Console.WriteLine("Type the width");
            string widths = Console.ReadLine();
            if (!int.TryParse(heights, out height) || !int.TryParse(widths, out width) || !int.TryParse(prices,out price))
                return;
            Console.WriteLine("The price would be {0} in a floor of {1}x{2}",(height * width) * price,height,width);
        }
    }
}
