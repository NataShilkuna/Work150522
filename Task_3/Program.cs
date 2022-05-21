
Console.Write("Введите пятизначиное число: ");
//int num = new Random().Next(1, 100);
int num = int.Parse(Console.ReadLine());
int r, sum=0, t;
for (t=num; num!=0; num = num/10)
{
r = num % 10;
sum=sum*10+r;
}
if (t==sum)
{
    Console.Write($"{t}  палиндром" , t);
}
    else
    {
        Console.Write($"{t} не палинром", t);
    }

