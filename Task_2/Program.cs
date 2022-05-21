
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("|{0,10}|{1,10}", "Число", "Корень");
for (int i = 1; i <= n; i++)
{
    Console.WriteLine("|{0,10}|{1,10}|", i, Math.Pow(i, 3));
}
