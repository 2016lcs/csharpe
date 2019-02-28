using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string s = "";
            double a,b,c;//定义两个将要输入的数字及其乘积
            Console.WriteLine("intput first date:");
            s = Console.ReadLine();
            a = double.Parse(s);
            Console.WriteLine("intput second date:");
            s = Console.ReadLine();
            b = double.Parse(s);
            c = a * b;
            Console.WriteLine($"乘积：{a}*{b}={c}");
        }
    }
}
