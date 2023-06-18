using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Class");

            UC1.CheckAttendance();

            UC2.employeewage();

            UC3.Parttimewage();

            UC4.switchcase();

            UC5.workingdays();

            UC6.workinghrs();
            Console.ReadLine();
        }
    }
}
