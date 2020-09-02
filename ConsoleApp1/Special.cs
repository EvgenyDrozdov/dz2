using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Special : hr
    {
        public string WaitForYourSalary()
        {
            return "Ждать зарплату";
        }
        public void performWork()
        {
            Console.WriteLine("Нужно работать что бы получить запрлату");
        }
        public void whine()
        {
            Console.WriteLine("не хочу работать");
        }
    }
}
