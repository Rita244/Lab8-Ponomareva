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









//самостоятельные
