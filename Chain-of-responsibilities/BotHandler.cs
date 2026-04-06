using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibilities
{
    public class BotHandler : SupportHandler
    {
        public override bool HandleRequest()
        {
            Console.WriteLine("[Рівень 1] Ваше питання стосується перевірки балансу?");
            Console.WriteLine("1 - Так, дізнатись баланс");
            Console.WriteLine("2 - Ні, інша проблема");
            Console.Write("Ваш вибір: ");

            string choice = Console.ReadLine();

            if(choice == "1")
            {
                Console.WriteLine("Ваг балланс дуже багато долярів. Дякуюємо що звернуолись");
                return true;
            }
            else
            {
                Console.WriteLine("Перемикаю на відділ фіансів, очікуйте");
                return base.HandleRequest();
            }
        }
    }
}
