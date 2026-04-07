using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategy
{
    public class NetworkLoadStrategy : IImageLoadStrategy
    {
        public void Load(string href)
        {
            Console.WriteLine($"Image {href} loaded from network");
        }
    }
}
