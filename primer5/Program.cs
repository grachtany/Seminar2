Console.Clear();
Console.Write("Введите число a - ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите число b - ");
int numberB = int.Parse(Console.ReadLine());

if (numberB == numberA*numberA) 
    Console.Write ($"{numberB}  является квадратом {numberA}");
else 
    Console.Write ($"{numberB}  не является квадратом {numberA}");