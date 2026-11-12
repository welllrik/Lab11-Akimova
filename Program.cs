int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
int target = 2000; 
bool found = false;
foreach (int record in recordBooks)
{
    if (record == target)
    {
        found = true;
        break;
    }
}
Console.WriteLine(found ? "Студент найден" : "Студент не найден");





int variant = 17;
bool isPrime = true;
if (variant < 2)
{
    isPrime = false; 
}
for (int divisor = 2; divisor < variant; divisor++)
{
    if (variant % divisor == 0)
    {
        isPrime = false;
        break;
    }
}
if (variant == 1)
{
    Console.WriteLine("Единица не считается ни простым, ни составным числом");
}
else
{
    Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");
}



int[] pointsPerLab = { 8, -1, 10, 9, -1, 7 };
int sum = 0;
int submitted = 0;
foreach (int points in pointsPerLab)
{
    if (points < 0)
    {
        continue; // -1 означает несданную работу
    }
    sum += points;
    submitted++;
}
Console.WriteLine($"Сумма баллов за сданные работы: {sum}, сдано работ: {submitted}");





int[] groupIds = { 101, 104, 107, 104, 110 };
bool hasDuplicates = false;
for (int i = 0; i < groupIds.Length; i++)
{
    for (int j = i + 1; j < groupIds.Length; j++)
    {
        if (groupIds[i] == groupIds[j])
        {
            Console.WriteLine($"Повторяющийся номер зачётки: {groupIds[i]} (позиции {i} и {j})");
            hasDuplicates = true;
            break;
        }
    }
    if (hasDuplicates)
    {
        break;
    }
}
if (!hasDuplicates)
{
    Console.WriteLine("Все номера уникальны");
}