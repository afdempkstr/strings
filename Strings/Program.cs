using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = "test";
            var last = s1[3];
            var length = s1.Length;
            last = s1[length - 1];

            s1 = "Mia fora kai ena kairo";
            Console.WriteLine(s1.ToLower());
            Console.WriteLine(s1.ToUpper());

            var index = s1.IndexOf("kai");
            Console.WriteLine(index);
            index = s1.LastIndexOf("kai");
            Console.WriteLine(index);

            s1 = " with spaces ththth";
            Console.WriteLine($"({s1.Trim()})");
            Console.WriteLine($"({s1.TrimStart()})");
            Console.WriteLine($"({s1.TrimEnd()})");

            Console.WriteLine($"({s1.Replace("s", "$$$")})");

            // replace the first "th" with "thout"
            index = s1.IndexOf("th");

            var s2 = s1.Substring(0, index) + "thout" + s1.Substring(index + "th".Length);
            Console.WriteLine(s2);

            Console.WriteLine(ReplaceFirst("patatakia", "ta", ""));

            StringBuilder sb = new StringBuilder("a long time ago in a galaxy far far away");

            sb[3] = 't';
            sb.Append(true);
            sb.Append(3.14);
            sb.Append("test test 123");

            sb.Replace("test", "experiment");

            sb.Insert(0, "begin");
            
            Console.WriteLine(sb.ToString());
            sb.Clear();
            
            Console.Read();
        }

        static string ReplaceFirst(string input, string search, string replace)
        {
            var position = input.IndexOf(search);
            if (position != -1)
            {
                return input.Substring(0, position) + replace + input.Substring(position + search.Length);
            }
            return input;
        }

    }
}
