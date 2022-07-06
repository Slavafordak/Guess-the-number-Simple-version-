int a, b,mid,c;
bool verno = false;
Console.WriteLine("Игра, угадай загаднное число");
Console.Write("Введите начальное число: ");
a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Загадайте число(целое) и не забудьте его!");
while (verno ==false)
{
    mid = (a + b) / 2;
    Console.WriteLine($"Число больше(1), меньше(2) или точное(3)? = {mid}");
    c = Convert.ToInt32(Console.ReadLine());
    if (c == 3)
    {
        Console.WriteLine($"Это число : {mid}");
        verno = true;
    }
    if (c == 1)
    {
        a = mid+1;
        verno = false;
    }
    if (c == 2)
    {
        b = mid-1;
        verno = false;
    }
}