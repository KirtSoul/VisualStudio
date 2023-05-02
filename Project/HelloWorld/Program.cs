// Импорт сторонних пространств имён
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Пространство имён
/// Создание собственной библиотеки
/// </summary>
namespace HelloWorld
{
    /// <summary>
    /// Главная составляющая единица приложения - класс
    /// Подробности в Теме 7 . Структуры и введение в ООП
    /// </summary>
    class Program
    {

         
        /// <summary>
        /// Код, который выполняется в первую очередь
        /// </summary>
        /// <param name="args">Параметры запуска</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); // вывод текста в консоль

            Console.Write("Hello ");
            Console.Write("World");
            Console.Write("! ");

            Console.ReadKey();  // Ожидание от пользователя нажатия какой-либо кнопки

        }
    }
}
