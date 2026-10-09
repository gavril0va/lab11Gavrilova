// int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
// int target = 1072;
// bool found = false;

// foreach (int number in recordBooks)
// {
//     if (number == target)
//     {
//         found = true;
//         break;
//     }
// }

// Console.WriteLine(found ? "Студент найден" : "Студент не найден");

// int variant = 1;
// bool isPrime = true;

//     if (variant < 2) {
//         Console.WriteLine("Число не является ни простым, ни составным");
//         return;
//     }
//     for (int divisor = 2; divisor < variant; divisor++) {
//         if (variant % divisor == 0) {
//         isPrime = false;
//         break;
//         }

// }

// Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");

// int[] pointsPerLab = { 8, -1, 10, 9, -1, 7 };
// int sum = 0;
// int count = 0;

// foreach (int points in pointsPerLab)
// {
//     if (points < 0)
//     {
//         continue; 
//     }
//     sum += points;
//     count++;
// }

// Console.WriteLine($"Сумма баллов за сданные работы: {sum}");
// Console.WriteLine($"Сдано работ: {count}");


// int [] groupIds = { 101, 104, 107, 104, 110 };
// bool Duplicates = false;
// int dup1 = 0, dup2 = 0;

// for (int i = 0; i < groupIds.Length; i++)
// {
//     for (int j = i + 1; j < groupIds.Length; j++)
//     {
//         if (groupIds[i] == groupIds[j])
//         {
//             Duplicates = true;
//             dup1 = groupIds[i];
//             dup2 = groupIds[j];
//             break;
//         }
//     }
// }

// if (Duplicates)
// {
//     Console.WriteLine($"Найдены дубликаты: {dup1} и {dup2}");
// }
// else
// {
//     Console.WriteLine("Дубликатов нет");
// }

// int days = 5;
// int lessonsPerDay = 6;
// bool found = false;

// for (int day = 1; day <= days && !found; day++)
// {
//     for (int lesson = 1; lesson <= lessonsPerDay; lesson++)
//     {
//         bool isFree = (day == 3 && lesson == 4);
//         if (isFree)
//         {
//             Console.WriteLine($"Свободный слот: день {day}, урок {lesson}");
//             found = true;
//             break; 
//         }
//     }
// }

// if (!found)
// {
//     Console.WriteLine("Свободных слотов нет");
// }


//ЗАДАЧА В
// int[] m = { 4, 7, 10, 3, 8, 5 };
// int summ = 0;

// foreach (int x in m)
// {
//     if (x % 2 != 0)
//     {
//         continue;
//     }
//     summ += x;
// }

// Console.WriteLine($"Сумма чётных: {summ}");


//ЗАДАЧА Г
// int[] M = { 1, 0, 3, 2, 5 };
// bool povtor = false;

// for (int i = 0; i < M.Length; i++)
// {
//     for (int j = i + 1; j < M.Length; j++)
//     {
//         if (M[i] == M[j])
//         {
//             povtor = true;
//             break;
//         }
//     }
// }

// Console.WriteLine(povtor ? "Есть дубликаты" : "Дубликатов нет");


// Console.Write("Введите свою фамилию: "); 
// string surname = Console.ReadLine()!.Trim(); 
// if (string.IsNullOrEmpty(surname)) { 
// Console.WriteLine("Фамилия не введена. Завершение работы."); 
// return; 
// } 
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear); 
// var assigned = Enumerable.Range(1, 10) 
// .OrderBy(_ => rnd.Next()) 
// .Take(2) 
// .OrderBy(x => x) 
// .ToList(); 
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


//ВАРИАНТ 1
// int[] arr = { 4, 7, 3, 9, 1 };
// int firstI = -1;

// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] < 0)
//     {
//         firstI = i;
//         break;
//     }
// }

// if (firstI != -1)
// {
//     Console.WriteLine($"Первое отрицательное: индекс {firstI}, значение {arr[firstI]}");
// }
// else
// {
//     Console.WriteLine("Не найдено");
// }


Console.WriteLine("Вводите числа, для завершения введите 0:");

int num2 = int.Parse(Console.ReadLine());

while (num2 != 0)
{
    bool isPrime2 = true;

    if (num2 < 2)
    {
        isPrime2 = false;
    }
    else
    {
        for (int d = 2; d < num2; d++)
        {
            if (num2 % d == 0)
            {
                isPrime2 = false;
                break;
            }
        }
    }

    Console.WriteLine($"{num2} — {(isPrime2 ? "простое" : "составное")}");
    num2 = int.Parse(Console.ReadLine());
}

Console.WriteLine("Ввод завершён");
