// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Read (string argument)
{
  int number;
  Console.WriteLine($"ВВедите число {argument}:");
  while ((!int.TryParse(Console.ReadLine(), out number)))
  {
    Console.WriteLine("Упс! Это не число. Попробуйте еще раз)");
  }
  return number;
}

double NaturalDegree()
{
int A = Read("A");
int B = Read("B");
double Degree = Math.Pow(A,B);
return Degree;
}

void Answer()
{
  double D = NaturalDegree();
  Console.WriteLine($"Число {"A"}, возведенное в  натуральну степень {"B"}, дает результат: {D}");
}

Answer();