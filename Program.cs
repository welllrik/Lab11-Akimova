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
