using System.IO;
using System.Diagnostics;
using Newtonsoft.Json;

namespace CalculatorLibrary {
    public class Calculate {
        JsonWriter writer;
        public Calculate() {
            StreamWriter logfile = File.CreateText("calculator.log");
            logfile.AutoFlush = true;
            writer = new JsonTextWriter(logfile);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartObject();
            writer.WritePropertyName("계산목록");
            writer.WriteStartArray();

            //Trace.Listeners.Add(new TextWriterTraceListener(logfile));
            //Trace.AutoFlush = true;
            //Trace.WriteLine("Starting Calculator Log");
            //Trace.WriteLine(String.Format("Started {0}", System.DateTime.Now.ToString()));
        }
        public double DoOperation(double a, double b, String s) {
            double result = double.NaN;
            writer.WriteStartObject();
            writer.WritePropertyName("수1");
            writer.WriteValue(a);
            writer.WritePropertyName("수2");
            writer.WriteValue(b);
            writer.WritePropertyName("계산 형식");
            switch (s) {
                case "a":
                    writer.WriteValue("더하기");
                    result = a + b;
                    //Trace.WriteLine(String.Format("{0} + {1} = {2}",a,b,result));
                    break;
                case "s":
                    writer.WriteValue("빼기");
                    result = a - b;
                    //Trace.WriteLine(String.Format("{0} + {1} = {2}", a, b, result));
                    break;
                case "m":
                    writer.WriteValue("곱하기");
                    result = a * b;
                    //Trace.WriteLine(String.Format("{0} + {1} = {2}", a, b, result));
                    break;
                case "d":
                    writer.WriteValue("나누기");
                    if (b == 0)
                        break;
                    result = a / b;
                    //Trace.WriteLine(String.Format("{0} + {1} = {2}", a, b, result));
                    break;
                default:
                    break;
            }
            writer.WritePropertyName("결과");
            writer.WriteValue(result);
            writer.WriteEndObject();
            return result;
        }
        public void Finish() {
            writer.WriteEndArray();
            writer.WriteEndObject();
            writer.Close();
        }
    }
}