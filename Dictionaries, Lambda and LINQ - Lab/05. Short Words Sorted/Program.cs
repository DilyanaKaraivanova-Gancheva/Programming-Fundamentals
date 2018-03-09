using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().ToLower().Split(new char[] { '.',',',':',';','(',')','[',']','\"','\'','\\','/','!','?',' ' }
            , StringSplitOptions.RemoveEmptyEntries).ToList();

            words = words.Where(w => w.Length < 5).OrderBy(w => w).Distinct().ToList();

            Console.WriteLine(string.Join(", ",words));
        }
    }
}
