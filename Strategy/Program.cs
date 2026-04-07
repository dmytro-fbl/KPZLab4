using Strategy;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            LightImageNode webImage = new LightImageNode("https://anysite.com/cat.png");

            LightImageNode localImage = new LightImageNode("C:\\Images\\dog.jpg");

            Console.WriteLine("Завантажуємо першу картинку:");
            webImage.LoadImage(); 

            Console.WriteLine("\nЗавантажуємо другу картинку:");
            localImage.LoadImage(); 

            Console.WriteLine(webImage.OuterHtml);
            Console.WriteLine(localImage.OuterHtml);

            Console.ReadKey();
        }
    }
}
