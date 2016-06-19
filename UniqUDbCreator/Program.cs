using System;
using System.Linq;

namespace UniqUDbManager
{
    class Program
    {
        static void Main(string[] args)
        {
            UniqUDbContext context = new UniqUDbContext();

            var styles = from style in context.StylesOfClothes
                        select style;
            var types = from type in context.TypesOfClothes
                        select type;

            Console.WriteLine("All types");
            foreach (var type in types)
            {
                Console.WriteLine(type.Name);
            }

            Console.WriteLine("All styles");
            foreach (var style in styles)
            {
                Console.WriteLine(style.Name);
            }

            Console.ReadLine();
        }
    }
}
