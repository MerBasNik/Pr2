using System.Net.Security;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp2
{
    internal class Program
    {
        private static string Encryption(string message, int key)
        {
            string CryptStr = "";
            string alpha = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            foreach (char c in message)
            {
                if (alpha.IndexOf(c) != -1)
                    CryptStr = CryptStr + alpha[(alpha.IndexOf(c) + key) % alpha.Length];
                else
                {
                    CryptStr += c;
                }
            }
            return CryptStr;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Шифр Цезаря");
            Console.WriteLine("Введите строку для шифрования/дешифрования...");
            string message = Console.ReadLine();
            Console.WriteLine("Введите ключ для шифрования/дешифрования...");
            
            int key = int.Parse(Console.ReadLine());

            message = message.ToLower();
            message = Encryption(message, key);
            Console.WriteLine("Готовое сообщение: " + message);
        }
    }
}