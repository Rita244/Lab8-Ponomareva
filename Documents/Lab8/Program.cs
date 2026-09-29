// int lessonNumber = 5;
// int totalLessons = 5;

// while (lessonNumber >= 1)
// {
//     Console.WriteLine($"Пара {lessonNumber}");
//     lessonNumber--;
// }

// Console.WriteLine("Пары закончились");








// Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());
// int count = 0;
// while (grade != -1)
// {
//     Console.WriteLine($"Оценка принята: {grade}");
//     grade = int.Parse(Console.ReadLine());
//     count++;
// }

// Console.WriteLine("Ввод завершён");
// Console.WriteLine(count);








// int sum = 0;
// int count = 0;
// int max = 0;

// Console.WriteLine("Вводите оценки, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());
// while (grade != -1)
// {
//     sum += grade;
//     count++;
//     grade = int.Parse(Console.ReadLine());
//     if (grade > max)
//     {
//         max = grade;
//     }
// }

// if (count > 0)
// {
//     Console.WriteLine($"Средний балл: {(double)sum / count}");
//     Console.WriteLine($"Наибольшая оценка: {max}");
// }
// else
// {
//     Console.WriteLine("Оценок не было введено");
// }









// string correctPassword = "qwerty123";
// int count = 0;
// while (true)
// {
//     Console.Write("Введите пароль от личного кабинета: ");
//     string password = Console.ReadLine();

//     if (password == correctPassword)
//     {
//         Console.WriteLine("Доступ разрешён");
//         break;
//     }

//     Console.WriteLine("Неверный пароль, попробуйте снова");
//     count++;
// }
// Console.WriteLine($"Количество неверных попыток: {count}");










// string answer;
// do
// {
//     Console.Write("Введите дату посещения (Например, 01.09): ");
//     string date = Console.ReadLine();
//     Console.WriteLine($"Запись добавлена: {date}");

//     Console.Write("Добавить еще одну запись? (да/нет): ");
//     answer = Console.ReadLine();
// } while (answer == "да");

// Console.WriteLine("Дневник сохранён");


// ##Самостоятельные задания


// using System;

// class Program
// {
//     static void Main()
//     {
//         int N = 5; 

//         Console.WriteLine($"Таблица умножения на {N}:");

//         // Цикл-счётчик от 1 до 10
//         for (int i = 1; i <= 10; i++)
//         {
//             Console.WriteLine($"{N} * {i} = {N * i}");
//         }
//     }
// }

// using System;

// class Program
// {
//     static void Main()
//     {
//         string input = "";
//         int count = 0; 

//         Console.WriteLine("Вводите имена учеников (для завершения введите 'конец'):");

//         while (input != "конец")
//         {
//             Console.Write("Введите имя: ");
//             input = Console.ReadLine();
//             if (input == "конец")
//             {
//                 break; 
//             }
//             count++;
//         }
//         Console.WriteLine($"\nВсего было введено имён: {count}");
//     }
// }

// ##Индивидуальный вариант 

// using System;
// using System.Linq;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите свою фамилию: ");
//         string surname = Console.ReadLine()!.Trim();

//         if (string.IsNullOrEmpty(surname)) {
//             Console.WriteLine("Фамилия не введена. Завершение работы.");
//             return;
//         }

//         Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

//         var assigned = Enumerable.Range(1, 10)
//             .OrderBy(_ => rnd.Next())
//             .Take(2)
//             .OrderBy(x => x)
//             .ToList();

// //         Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");
//     }
// }

// ##ВАРИАНТ 9

// using System;

// class Program
// {
//     static void Main()
//     {
//         int N = 10; 
//         int sum = 0;

//         Console.WriteLine($"Считаем сумму четных чисел от 1 до {N}:");

//         for (int i = 1; i <= N; i++)
//         {

//             if (i % 2 == 0)
//             {
//                 sum += i; 
//             }
//         }

//         Console.WriteLine($"Сумма четных чисел: {sum}");
//     }
// }

//  ##ВАРИАНТ 10

using System;

class Program
{
    static void Main()
    {
        int grade = 0;
        int countFives = 0; 

        Console.WriteLine("Вводите оценки (для завершения введите -1):");

        while (grade != -1)
        {
            Console.Write("Введите оценку: ");

            if (int.TryParse(Console.ReadLine(), out grade))
            {
                if (grade == -1)
                {
                    break;
                }
                if (grade == 5)
                {
                    countFives++;
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введите целое число.");
            }
        }

        Console.WriteLine($"\nКоличество отличных оценок (5): {countFives}");
    }
}