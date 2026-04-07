using System.Text;
using Composite;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var div = new LightElementNode("div", DisplayType.Block, ClosingType.Paired, new List<string> { "container" });

            var button = new LightElementNode("button", DisplayType.Inline, ClosingType.Paired, new List<string> { "btn-primary" });
            button.Add(new LightTextNode("Натисни мене!"));

            var image = new LightElementNode("img", DisplayType.Inline, ClosingType.Single, new List<string> { "logo" });

            div.Add(button);
            div.Add(image);

            Console.WriteLine("СТРУКТУРА СТОРІНКИ");
            Console.WriteLine(div.OuterHtml);

            button.AddEventListener("click", () =>
            {
                Console.WriteLine("Зберігаю дані форми в базу");
            });

            button.AddEventListener("click", () =>
            {
                Console.WriteLine("Відправляю аналітику про клік");
            });

            image.AddEventListener("mouseover", () =>
            {
                Console.WriteLine("Показую підказку 'Це наше лого' над картинкою.");
            });

            Console.WriteLine("Користувач наводить мишку на картинку");
            image.TriggerEvent("mouseover");

            Console.WriteLine("\nКористувач клікає на кнопку");
            button.TriggerEvent("click");

            Console.ReadKey();
        }
    }
}
