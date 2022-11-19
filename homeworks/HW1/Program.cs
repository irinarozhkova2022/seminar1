//ZADACH2//

/*Console.WriteLine("Input number 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num1 > num2 ? "Первое число больше второго" : "Второе число больше первого");*/

//ZADACH4//

/*Console.WriteLine("Input number 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 2");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number 3");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.WriteLine("Максимальное число: " + num1);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + num3);
    }
}

else if (num2 > num3)
{
    Console.WriteLine("Максимальное число: " + num2);
}
else
{
    Console.WriteLine("Максимальное число: " + num3);
}*/

//ZADACH6//

/*Console.WriteLine("Input number N");
int numN= Convert.ToInt32(Console.ReadLine());
if (numN % 2 == 0)
{
    Console.WriteLine($"{numN} ЧЕТНОЕ");
}
else
{
    Console.WriteLine($"{numN} НЕЧЕТНОЕ");
}*/

//ZADACH8//

/*Console.WriteLine("Input number N");
int numN = Convert.ToInt32(Console.ReadLine());
int i = 1;
bool not = true;
Console.WriteLine("Чётные числа от 1 до " + numN);
while (i <= numN)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;
}
if (not)
{
    Console.WriteLine("Нет чётных чисел!");
}*/