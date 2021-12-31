using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào tên của bạn:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
            Console.WriteLine("Welcome to NTQ Solution");
            Console.ReadKey();
        }
    }
}
