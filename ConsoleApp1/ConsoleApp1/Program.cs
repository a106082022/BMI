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
            Console.Write("請輸入身高(CM):");
            double CM = double.Parse(Console.ReadLine());  //讓程式知道身高
            Console.Write("請輸入體重(KG):");
            double KG = double.Parse(Console.ReadLine());  //讓程式知道體重
            double BMI = KG / (CM/100 * CM/100);           //讓程式算BMI
            Console.WriteLine("BMI值為"+BMI);              //讓程告訴我BMI

            if (BMI < 18.5)                                //判斷BMI
                Console.WriteLine("體重過輕");
            else if (18.5 <= BMI && BMI < 24)
                Console.WriteLine("體重正常");
            else if (24 <= BMI && BMI < 27.9)
                Console.WriteLine("超重");
            else if (28 <= BMI)
                Console.WriteLine("肥胖");
            else
                Console.WriteLine("請檢察輸入數值");
            if (BMI < 16.5)
                Console.WriteLine("免役");
            else if (BMI > 31.5)
                Console.WriteLine("免役");
            else if (CM <= 157)
                Console.WriteLine("免役");
            else if (CM >= 196)
                Console.WriteLine("免役");
            else if (17 <= BMI && BMI <= 31)
                Console.WriteLine("常備役");
            else if (31 < BMI && BMI <= 31.5)
                Console.WriteLine("替代役");
            else if (16.5 <= BMI && BMI < 17)
                Console.WriteLine("替代役");
            else
                Console.WriteLine("請檢察輸入數值");
            Console.Read();
        }
    }
}
