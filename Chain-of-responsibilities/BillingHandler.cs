using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibilities
{
    public class BillingHandler : SupportHandler
    {
        public override bool HandleRequest()
        {
            Console.WriteLine("[Рівень 2] Ваше питання тарифного плану?");
            Console.WriteLine("1 - Так, змінити тариф");
            Console.WriteLine("2 - Ні, інша проблема");
            Console.Write("Ваш вибір: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Ваш тариф змінено. Дякуюємо що звернуолись");
                return true;
            }
            else
            {
                Console.WriteLine("Перемикаю на технічний відділ, очікуйте");
                return base.HandleRequest();
            }
        }
    }
}
