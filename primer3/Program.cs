Console.Clear();
Console.Write("Введите число a - ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число b - ");
int numberB = int.Parse(Console.ReadLine());
int ostatok = numberA%numberB;
if (ostatok ==0) Console.Write ($"{numberA}  Кратно {numberB}");
else 
{Console.Write ($"{numberA}  не кратно {numberB}, остаток {ostatok}");}