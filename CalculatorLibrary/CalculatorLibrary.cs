using System.IO;
using System.Diagnostics;

namespace CalculatorLibrary {
    public class Calculate {
        public Calculate() {
            StreamWriter logfile = File.CreateText("calculator.log");
            Trace.Listeners.Add(new TextWriterTraceListener(logfile));
            Trace.AutoFlush = true;
            Trace.WriteLine("Starting Calculator Log");
            Trace.WriteLine(String.Format("Started {0}", System.DateTime.Now.ToString()));
        }
        public double DoOperation(double a, double b, String s) {
            double result = double.NaN;

            switch (s) {
                case "a":
                    result = a + b;
                    Trace.WriteLine(String.Format("{0} + {1} = {2}",a,b,result));
                    break;
                case "s":
                    result = a - b;
                    Trace.WriteLine(String.Format("{0} + {1} = {2}", a, b, result));
                    break;
                case "m":
                    result = a * b;
                    Trace.WriteLine(String.Format("{0} + {1} = {2}", a, b, result));
                    break;
                case "d":
                    if (b == 0)
                        break;
                    result = a / b;
                    Trace.WriteLine(String.Format("{0} + {1} = {2}", a, b, result));
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}