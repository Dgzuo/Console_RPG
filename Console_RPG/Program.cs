using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            string PlayerName;
            Console.WriteLine("Имя");
            PlayerName = Console.ReadLine();
            string Race;
            Console.WriteLine("Раса");
            Race = Console.ReadLine();
            int Age;
            Console.WriteLine("Возраст");
            Age = int.Parse (Console.ReadLine());
            string sex;
            Console.WriteLine("Пол");
            sex = Console.ReadLine();
            int level;
            Console.WriteLine("Уровень");
            level = int.Parse(Console.ReadLine());
            string playerClass;
            Console.WriteLine("Класс");
            playerClass = Console.ReadLine();
            int action;
            Console.WriteLine("1-Идти " + "2-Говорить " + "3-Отдыхать " + "4-Закончить День");
            Console.WriteLine("0-Выход из игры");

            while(true)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("Введите действие");
                    action = int.Parse(Console.ReadLine());
                    if (action == 1)
                    {
                        Console.WriteLine($"{PlayerName} Прошол 15М");
                    }
                    if (action == 2)
                    {
                        Console.WriteLine($"{PlayerName} Болтал");
                    }
                    if (action == 3)
                    {
                        Console.WriteLine($"{PlayerName} отдыхал до утра");
                    }
                    if (action == 4)
                    {
                        Console.WriteLine($"День завершон");
                    }
                }
                if (Console.ReadLine() == "0")
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
