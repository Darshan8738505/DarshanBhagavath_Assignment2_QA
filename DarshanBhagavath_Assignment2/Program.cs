using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarshanBhagavath_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int len = 0;
                int wid = 0;

                Console.WriteLine("The Rectangle values for a default constructor : ");

                Rectangle rt = new Rectangle();

                Console.WriteLine("Area of the Rectangle is :" + rt.GetArea());
                Console.WriteLine("Perimeter of the Rectangle is :" + rt.GetPerimeter());

                Console.WriteLine("----------------------------------------------------------------------");

                Console.Write("Enter the length of the rectangle for non-default: ");
                len = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the width of the rectangle for non-default: ");
                wid = Convert.ToInt32(Console.ReadLine());

                Rectangle rt2 = new Rectangle(len, wid);
                rt2.GetLength();
                rt.GetWidth();
                rt.SetLength(len);
                rt.SetWidth(wid);

                Console.WriteLine("Area of the Rectangle for non-default is :" + rt2.GetArea());
                Console.WriteLine("Perimeter of the Rectangle for non-default is :" + rt2.GetPerimeter());

                Console.ReadKey();
            }
              catch (Exception e)
             {
              Console.WriteLine(e.Message);
             }
        }

    }
}
