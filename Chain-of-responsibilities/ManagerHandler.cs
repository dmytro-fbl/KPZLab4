using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibilities
{
    public class ManagerHandler : SupportHandler
    {
        public override bool HandleRequest()
        {
            Console.WriteLine("[Рівень 4] Чи бажаєте залишити скаргу або поговорити з реальною людиною?");
            Console.WriteLine("1 - Так, так маю скаргу");
            Console.WriteLine("2 - Ні");
            Console.Write("Ваш вибір: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Ваша скарга була прийнята. Менеджер зв'яжеться з вами. Дякуюємо що звернуолись");
                return true;
            }
            else
            {
                Console.WriteLine("На жаль не змогли розпізнати вашу проблему");
                return base.HandleRequest();
            }
        }
    }
}
