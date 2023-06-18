using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision Problems");

            LineBased.Calculatelength();

            Equality.Equal();

            EndPoint.Greaterorless();
        }
    }
}
