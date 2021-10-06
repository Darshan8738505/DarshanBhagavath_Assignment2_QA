using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarshanBhagavath_Assignment2
{
    public class Rectangle
    {
        private int length;
        private int width;

        //Default Constructor
        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        //Parameterised - non default constructor
        public Rectangle(int l, int w)
        {
            length = l;
            width = w;
        }

        public int GetLength()
        {
            return length;
        }

        public int SetLength(int len)
        {
            if ((len >= 0) && (len <= 20))
            {
                length = len;
                return length;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Length is out of range");
            }
        }

        public int GetWidth()
        {
            return width;
        }

        public int SetWidth(int wid)
        {
            if ((wid >= 0) && (wid <= 20))
            {
                width = wid;
                return width;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Width is out of range");
            }
            
        }

        public int GetPerimeter()
        {
            return 2*(length + width);
        }

        public int GetArea()
        {
            return (length*width);
        }
    }
}
