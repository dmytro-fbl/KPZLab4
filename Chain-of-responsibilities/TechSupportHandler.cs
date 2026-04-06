using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibilities
{
    public class TechSupportHandler :SupportHandler
    {
        public override bool HandleRequest()
        {
            Console.WriteLine("[Рівень 3] У вас проблема з інтернетом чи зв'язком?");
            Console.WriteLine("1 - Так, не працює інтернет");
            Console.WriteLine("2 - Ні, інша проблема");
            Console.Write("Ваш вибір: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Ми перезавантажили вашу лінію. Дякуюємо що звернуолись");
                return true;
            }
            else
            {
                Console.WriteLine("З'єднуємо з головним менеджером, очікуйте");
                return base.HandleRequest();
            }
        }
    }
}
