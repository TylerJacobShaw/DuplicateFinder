using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateFinder.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<int> { 1001, 1002, 1004, 1004, 1001, 1006, 1007, 1008, 1009, 1001 };
            bool hasAllUniqueEventIds = list.GroupBy(id => id).All(group => group.Count() == 1);
            if (hasAllUniqueEventIds)
            {
                Console.WriteLine("No duplicates were found");
            }
            else
            {
                List<int> duplicates = list.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key).ToList();
                var items = string.Join(",", duplicates.Select(n => n.ToString()).ToArray());
                Console.WriteLine($"Duplicate EventID's were found: {items}");
            }

            Console.ReadLine();
        }
    }
}
