using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegates
{
    //Step :1 Defining of the delegate
    public delegate void RectDelegate(double Width, double Height);


    class Rectangle
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine("Area of rectangle :" + Width * Height);
        }

        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine("Perimeter of rectangle :" + 2 * (Width + Height));
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();

            RectDelegate obj = new RectDelegate(rect.GetArea);//Instantiating of the delegate

            obj += rect.GetPerimeter;//Multicast Delegate

            obj.Invoke(12.34, 56.78);//Parameter passing

            Console.WriteLine();
            obj.Invoke(47.87, 34.89);// other rectangles properties also can be obtained by single call of delegate
                
            Console.ReadKey();
        }
    }
}
