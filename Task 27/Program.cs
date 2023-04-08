// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int Read (string argument)
{
  int number;
  Console.WriteLine($"Введите число {argument}:");
  while ((!int.TryParse(Console.ReadLine(), out number)))
  {
    Console.WriteLine("Упс! Это не число. Попробуйте еще раз)");
  }
  return number;
}
int a = Read("a");  
int len = Length(a);
Console.Write($"Сумма цифр в числе {a} равно: {Sum(a,len)}");

int Length(int a)
{
int index = 0;
while (a > 0)
{
a /= 10;
index++;
}
return index;
}

int Sum(int a, int len)
{
int sum = 0;
for (int i = 1; i <= len; i++)
{
sum += a % 10;
a /= 10;
}
return sum;
}
