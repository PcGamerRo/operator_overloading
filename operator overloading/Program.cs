using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Entity entity_one = new Entity(1, new int[] { 1, 2 });
            Entity entity_two = new Entity(2, new int[] { 3, 4 });

            int x = 0;
            x = x + entity_one;
            entity_one += 1;
            entity_one++;

            entity_one[0] = -1;
            Console.WriteLine(entity_one[0]);

            Console.WriteLine(entity_one.Id + " " + entity_two.Id);
            Console.WriteLine(entity_one > entity_two);
        }
    }
}