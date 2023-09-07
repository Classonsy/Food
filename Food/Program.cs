using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money;
            int food;
            int FoodUnitPrice = 10;
            bool isAbleToPay;
            Console.WriteLine($"Добро пожаловать в пекарню! Сегодня еда по {FoodUnitPrice} монет ");
            Console.WriteLine("Сколько у вас золота?");
                money =  Convert.ToInt32(Console.ReadLine());
            Console.Write("Выберите колличество еды:");
            food = Convert.ToInt32(Console.ReadLine());

            isAbleToPay = money >= food * FoodUnitPrice;
            food *= Convert.ToInt32(isAbleToPay);

            money -= food * FoodUnitPrice;
            Console.WriteLine($"У вас в сумке {food} единиц еды, и {money} монет.");
        }
    }
}
