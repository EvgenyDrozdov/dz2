using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Special : hr
    {
        public void WaitForYourSalary(string money)
        {
            if (money.ToLower() == "Зарплата")
            {
                Console.WriteLine("Ура, гуляем!!");
            }
            else
            {
                Console.WriteLine("Как задерживают????");
            }
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
