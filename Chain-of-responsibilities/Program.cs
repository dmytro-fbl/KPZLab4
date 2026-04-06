namespace Chain_of_responsibilities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            SupportHandler bot = new BotHandler();
            SupportHandler billing = new BillingHandler();
            SupportHandler tech = new TechSupportHandler();
            SupportHandler manager = new ManagerHandler();

            bot.SetNext(billing).SetNext(tech).SetNext(manager);

            bool isResolved = false;

            while (!isResolved)
            {
                isResolved = bot.HandleRequest();
                if (!isResolved)
                {
                    Console.WriteLine("\n ПРОБЛЕМУ НЕ ВИРІШЕНО");
                    Console.WriteLine("Повертаємо вас у головне меню...\n");
                }
                
            }

            Console.WriteLine("\nДякуємо за звернення! Натисніть будь-яку клавішу для виходу.");
            Console.ReadKey();
        }
    }
}
