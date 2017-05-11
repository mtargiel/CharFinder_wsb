using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz dowolne zdanie");
            string zdanie = Console.ReadLine();
            Console.WriteLine("Jakiego znaku szukać?");
            char znak;
            char.TryParse(Console.ReadLine(), out znak);
            Find find = new Find(zdanie, znak);
            Console.WriteLine(find.policzZnaki());
            Console.ReadKey();
        }
    }
}
