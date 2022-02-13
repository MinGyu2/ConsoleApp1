using System;
using CalculatorLibrary;
namespace Cacu{
    
    class Prog{
        static void Main(String[] args) {
            Calculate calculate = new Calculate();
            bool endApp = false;
            while (!endApp) {
                double num1, num2;
                string n1=null, n2=null;
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
                //double re = CalculatorLibrary.Calculate.DoOperation(num1, num2, a);
                
                //double re = Calculate.DoOperation(num1, num2, a);
                double re = calculate.DoOperation(num1, num2, a);
                Console.WriteLine($"결과: {re}");

                Console.WriteLine("끝내게 습니까?(y/n)");
                if(Console.ReadLine() == "y") endApp=true;

                Console.WriteLine("========================================================\n");
            }
            calculate.Finish();
        }
    }
}