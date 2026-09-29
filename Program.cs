// int lessonNumber = 5;
// int totalLessons = 5;

// while (lessonNumber >= 1)
// {
//     Console.WriteLine($"Пара {lessonNumber}");
//     lessonNumber--;
// }

// Console.WriteLine("Пары закончились");








Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());
int count = 0;
while (grade != -1)
{
    Console.WriteLine($"Оценка принята: {grade}");
    grade = int.Parse(Console.ReadLine());
    count++;
}

Console.WriteLine("Ввод завершён");
Console.WriteLine(count);
