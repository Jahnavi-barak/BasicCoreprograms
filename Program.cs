using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leapyear2
{
    class Leapyear2
    {
        static void Main(string[] args)
        {
            Leapyear2 obj = new Leapyear2();
            obj.readdata();
            obj.leap();
        }
        int y;
        public void readdata()
        {
            Console.WriteLine("Enter the year in four Digits : ");
            y = Convert.ToInt32(Console.ReadLine());
        }
        public void leap()
        {
            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
            {
                Console.WriteLine("{0} is a Leap year", y);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap year", y);
            }
            Console.ReadLine();
        }
    }
}
