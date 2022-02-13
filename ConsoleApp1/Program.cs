using System;

namespace Cacu{
    class Calculate {
        public static double DoOperation(double a,double b,String s) {
            double result = double.NaN;

            switch (s) {
                case "a":
                    result = a + b;
                    break;
                case "s":
                    result = a - b;
                    break;
                case "m":
                    result = a * b;
                    break;
                case "d":
                    if (b == 0)
                        break;
                    result = a / b;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
    class Prog{
        static void Main(String[] args) {
            bool endApp = false;
            while (!endApp) {
                double num1, num2;
                string n1="", n2="";
                do {
                    Console.WriteLine("첫 번째 숫자를 입력해 주세요!");
                    n1 = Console.ReadLine();
                } while (!double.TryParse(n1, out num1));

                do {
                    Console.WriteLine("두 번째숫자를 입력해 주세요!");
                    n2 = Console.ReadLine();
                }while(!double.TryParse(n2, out num2));

                Console.WriteLine("더하기(a),빼기(s),곱하기(m),나누기(d)");
                string a= Console.ReadLine();
                double re = Calculate.DoOperation(num1, num2, a);
                Console.WriteLine($"결과: {re}");

                Console.WriteLine("끝내게 습니까?(y/n)");
                if(Console.ReadLine() == "y") endApp=true;

                Console.WriteLine("======================================================\n");
            }
        }
    }
}