
Console.Write("Введите координату X для точки A:");
int xA= int.Parse(Console.ReadLine());
Console.Write("Введите координату y для точки A:");
int yA= int.Parse(Console.ReadLine());
Console.Write("Введите координату X для точки B:");
int xB= int.Parse(Console.ReadLine());
Console.Write("Введите координату Y для точки B:");
int yB= int.Parse(Console.ReadLine());
Console.Write("Введите координату Z для точки A:");
int zA= int.Parse(Console.ReadLine());
Console.Write("Введите координату z для точки B:");
int zB= int.Parse(Console.ReadLine());

float getDistance(int x1, int y1, int x2, int y2, int z1, int z2)
{
    float result = (float)(Math.Sqrt((Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-y1, 2))));
    return result;
}
Console.WriteLine("{0: 0}", getDistance(xA, yA, xB, yB, zA, zB));