double pointX;
double pointY;

Console.Write("Введите значения b1, k1, b2 и k2 через пробел: ");
int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int b1 = arr [1];
int k1 = arr [3];
int b2 = arr [0];
int k2 = arr [2];

if (b1 == k1)
{
    Console.WriteLine("Прямые не пересекаются");
}
else
{
    pointX = (double) (k2-b2)/(b1-k1);
    pointY = (double) b1*(k2-b2)/(b1-k1) + b2;
    Console.WriteLine("Координаты точки пересечения двух прямых:"+ $"Х {pointX:0.00}"+ $" Y {pointY:0.00}");
    
}