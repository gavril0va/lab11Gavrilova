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


int [] groupIds = { 101, 104, 107, 104, 110 };
bool Duplicates = false;
int dup1 = 0, dup2 = 0;

for (int i = 0; i < groupIds.Length; i++)
{
    for (int j = i + 1; j < groupIds.Length; j++)
    {
        if (groupIds[i] == groupIds[j])
        {
            Duplicates = true;
            dup1 = groupIds[i];
            dup2 = groupIds[j];
            break;
        }
    }
}

if (Duplicates)
{
    Console.WriteLine($"Найдены дубликаты: {dup1} и {dup2}");
}
else
{
    Console.WriteLine("Дубликатов нет");
}
