Console.Clear();

Console.Clear();
Console.Write("Введите число a - ");

int numberA = int.Parse(Console.ReadLine());

int ostatok1 = numberA%7;
int ostatok2 = numberA%23;
if ((ostatok1 ==0) && (ostatok2 ==0))
    Console.Write ($"{numberA}  Кратно 7 и 23");
else 
    Console.Write ($"{numberA}  не кратно 7 и 23");



