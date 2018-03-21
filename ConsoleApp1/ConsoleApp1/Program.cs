using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("請輸入體重(KG):");
            double KG = double.Parse(Console.ReadLine());  //讓程式知道體重
            Console.Write("請輸入身高(CM):");              
            double CM = double.Parse(Console.ReadLine());  //讓程式知道身高
            double BMI = KG / (CM/100 * CM/100);           //讓程式算BMI
            Console.WriteLine("BMI值為"+BMI);              //讓程告訴我BMI
            Console.Read();
        }
    }
}
