using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "cat";
            string two = "dog";
            string three = "bird";
            string four = "fish";

            string someStr = "The quick brown fox jumped over the lazy dog";

            Console.WriteLine(someStr.Remove(9) + "...");
            Console.WriteLine(someStr);

            //someStr.Substring(<startIdx>, ?<length>);
            //someStr = someStr.Insert(8, "new string");

            //string.IsNullOrEmpty(someStr.Trim());
            //string.IsNullOrWhiteSpace(someStr);
            //if (!!!!!!string.IsNullOrEmpty(someStr)) {
            //}

            //someStr.Remove(someStr.IndexOf("lazy"), 4);
            //someStr = someStr.Replace("lazy", "");

            //Console.WriteLine(string.Format("{1}{3}{2}", one, two, three, four));
            //Console.WriteLine(one + " " + two + " " + three + " " + four);

            //var colors = new int[3]
            //{
            //    1, 3, 2
            //};
            //Array.Sort(colors);
            //Console.WriteLine(string.Join(", ", colors));

            Console.ReadLine();
        }
    }
}
