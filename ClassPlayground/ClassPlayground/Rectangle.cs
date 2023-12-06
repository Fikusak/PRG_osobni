using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class Rectangle
    {
        public int width;
        public int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void CalculateArea()
        {
            Console.WriteLine("Obsah je " + width * height + "j^2");
        }

        public void CalculateAspectRatio()
        {
            Console.WriteLine("Poměr a:b je " + width + ":" + height);
            if (width > height)
            {
                Console.WriteLine("Obdélník je široký");
            }
            else if(height > width) 
            {
                Console.WriteLine("Obdélník je vysoký");
            }
            else 
            {
                Console.WriteLine("Je to čtverec");
            }
        }

        public void ContainsPoint(int x, int y)
        {
            if (x <= width && x >= 0 && y <= height && y >= 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        
        
    }
}
