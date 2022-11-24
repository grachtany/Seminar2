int numberA = new Random().Next(10, 100)  ;
Console.WriteLine($"Случайное число {numberA}");
 int n1 = numberA/10;
 Console.WriteLine ($"Первая цифра {n1}");
 int n2 = numberA%10;
  Console.WriteLine ($"Вторая цифра {n2}");
if (n1>n2) Console.WriteLine($"Максимальное из двух чисел равно {n1}" );
if (n1<n2) Console.WriteLine($"Максимальное из двух чисел равно {n2}");

int max = n1;

if (n2>max)
{max=n2;
};
Console.WriteLine (max);

