using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStaticTest
{
    class Program
    {
        static void Main(string[] args)
        {
           // Log.StaticMethod();

            Log log = new Log();

            Log log2 = new Log();

            Log log3 = new Log();

            Console.ReadKey();
        }
    }

    public class Log
    {
        public Log()
        {
            Console.WriteLine("建構式");
        }

        public static string CacheData { get; set; }
        
        /// <summary>
        /// 靜態建構子，只會run一次，如果沒有使用到此物件，就完全不會run
        /// </summary>
        static Log()
        {
            Console.WriteLine("靜態建構式");
        }

        /// <summary>
        /// 有用到才會run
        /// </summary>
        public static void StaticMethod()
        {
            Console.WriteLine("static test");
        }
    }
}
