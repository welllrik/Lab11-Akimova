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



int days = 5;
int lessonsPerDay = 6;
bool slotFound = false;
for (int day = 1; day <= days && !slotFound; day++)
{
    for (int lesson = 1; lesson <= lessonsPerDay; lesson++)
    {
        bool isFree = (day == 3 && lesson == 4); 
        if (isFree)
        {
            Console.WriteLine($"Свободный слот: день {day}, урок {lesson}");
            slotFound = true;
            break;
        }
    }
}
if (!slotFound)
{
    Console.WriteLine("Свободных слотов нет");
}


int[] numsA = { 5, 12, 7, 20, 9 };
int searchValue = 20;
int foundIndex = -1;
for (int i = 0; i < numsA.Length; i++)
{
    if (numsA[i] == searchValue)
    {
        foundIndex = i;
        break;
    }
}
Console.WriteLine(foundIndex >= 0
    ? $"Число {searchValue} найдено на индексе {foundIndex}"
    : $"Числа {searchValue} в массиве нет");






int numberB = 29;
bool primeB = numberB >= 2;
for (int d = 2; d < numberB; d++)
{
    if (numberB % d == 0)
    {
        primeB = false;
        break;
    }
}
Console.WriteLine(primeB ? $"{numberB} — простое" : $"{numberB} — составное");



Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();
if (string.IsNullOrEmpty(surname))
{
    Console.WriteLine("Фамилия не введена. Завершение работы.");
    return;
}

Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
var assigned = Enumerable.Range(1, 10)
    .OrderBy(_ => rnd.Next())
    .Take(2)
    .OrderBy(x => x)
    .ToList();

Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");



for (; ; )
{
    Console.Write("Введите число (0 — выход): ");
    if (!int.TryParse(Console.ReadLine()!.Trim(), out int x))
    {
        Console.WriteLine("Это не число, попробуйте ещё раз");
        continue;
    }
    if (x == 0)
    {
        break;
    }

    bool prime = x >= 2;
    for (int d = 2; d < x; d++)
    {
        if (x % d == 0)
        {
            prime = false;
            break;
        }
    }

    if (x == 1)
    {
        Console.WriteLine("1 не считается ни простым, ни составным");
    }
    else
    {
        Console.WriteLine(prime ? $"{x} — простое" : $"{x} — составное");
    }
}




int[] firsta = { 5, 12, 7, 20 };
int[] seconda = { 9, 7, 3, 44 };
bool founda = false;
int commona = 0;

for (int i = 0; i < firsta.Length && !founda; i++)
{
    for (int j = 0; j < seconda.Length; j++)
    {
        if (firsta[i] == seconda[j])
        {
            commona = firsta[i];
            founda = true;
            break;
        }
    }
}

Console.WriteLine(founda ? $"Общий элемент: {commona}" : "Общих элементов нет");





int[] bonusArr = { 3, 8, 2, 11, 5, 6 };
int targetSum = 13;
bool pairFound = false;
for (int i = 0; i < bonusArr.Length && !pairFound; i++)
{
    for (int j = i + 1; j < bonusArr.Length; j++)
    {
        if (bonusArr[i] + bonusArr[j] == targetSum)
        {
            Console.WriteLine($"Пара с суммой {targetSum}: индексы {i} и {j} (числа {bonusArr[i]} и {bonusArr[j]})");
            pairFound = true;
            break;
        }
    }
}
if (!pairFound)
{
    Console.WriteLine("Пара не найдена");
}