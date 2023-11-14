using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputKeyboard
{
    public class EnterKeybord
    {

        public static object InputData(Type type, string message)
        {
            if (type == typeof(int))
            {
                return TypeInteger(message);
            }
            else if (type == typeof(double))
            {
                return TypeDouble(message);
            }
            else if (type == typeof(string))
            {
                Console.WriteLine(message);
                return Console.ReadLine();
            }
            throw new InvalidCastException($"Не удалось преобразовать вводимые данные в тип {type.Name}");
        }

        public static bool ValidateData(int number, int min, int max)
        {
            return min <= number && number <= max;
        }

        public static int TypeInteger(string message, int minValue = int.MinValue, int maxValue = int.MaxValue)
        {
            int n;
            bool isCorrect = false;
            bool isValid = false;
            do
            {
                Console.Write(message);
                isCorrect = Int32.TryParse(Console.ReadLine(), out n);
                if (!isCorrect)
                {
                    Console.WriteLine("Ошибка: введённое значение не соответствует типу integer");
                }
                else
                {
                    isValid = ValidateData(n, minValue, maxValue);
                    if (!isValid)
                        Console.WriteLine("Ошибка: ввёденое значение не входит в заданные границы");
                }
            } while (!isCorrect || !isValid);
            return n;
        }

        public static bool ValidateData(double number, double minValue, double maxValue)
        {
            return number >= minValue && number <= maxValue;
        }

        public static double TypeDouble(string message, double minValue = Double.MinValue, double maxValue = Double.MaxValue)
        {
            double n;
            bool isCorrect = false;
            bool isValid = false;
            do
            {
                Console.Write(message);
                isCorrect = Double.TryParse(Console.ReadLine(), out n);
                if (!isCorrect)
                {
                    Console.WriteLine("Ошибка: введённое значение не соответствует типу double");
                }
                else
                {
                    isValid = ValidateData(n, minValue, maxValue);
                    if (!isValid)
                    {
                        Console.WriteLine("Ошибка: ввёденое значение не входит в заданные границы");
                    }
                }
            } while (!isCorrect || !isValid);
            return n;
        }
    }
}
