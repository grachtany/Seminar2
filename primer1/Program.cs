int numberA = new Random().Next (100, 1000)  ;
Console.WriteLine($"Случайное число {numberA}");
// int n1 = numberA/10;
// Console.WriteLine ($"при делении на 10 цифра {n1}");
// int n2 = n1%10;
// Console.WriteLine ($"Вторая цифра {n2}");
// int n3 = numberA%10;
// Console.WriteLine ($"Третья цифра {n3}");
// int n4 = numberA/100;
// Console.WriteLine ($"Первая цифра {n4}");
// int n5 =n4*10+n3;
// Console.WriteLine ($"ответ {n5}");

int n1 = (numberA/100)*10+numberA%10;
Console.WriteLine ($"{numberA} -> {n1}");