// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран


int [] ints = new int[8];
int length = ints.Length;

Method(length);
void Method(int length)
{
for (int i = 0; i <length; i++)
{
ints [i] = new Random().Next(-100,101);
Console.Write($"{ints[i]}, ");
}
}
