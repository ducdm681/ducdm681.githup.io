using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueType_ReferenceType
{
    class Program
    {
        public static void SwapValue(int a, int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        public static void SwapReference_ref(ref int a,ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        public static void SwapReference_out (out int a,out int b)
        {
            
            a = 0;
            b = 3;
            int c = a;
            a = b;
            b = c;
        }
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Console.WriteLine("gia tri bien a;b truoc khi thay doi: "+ a + ";" + b);
            
            Console.Write("Value Type: ");
            SwapValue(a, b);
            Console.WriteLine(a + ";" + b);
            Console.Write("Reference Type (ref): ");
            SwapReference_ref(ref a,ref b);
            Console.WriteLine(a + ";" + b);
            Console.Write("Reference Type (out): ");
            SwapReference_out(out a,out b);
            Console.WriteLine(a + ";" + b);
            Console.ReadLine();
        }
    }
}
