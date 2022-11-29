/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
int Exponentiation(int A, int B)
{
  int result = 1;
  for(int i = 1; i <= B; i++)
  {
    result = result * A;
  }
  return result;
}
Console.Write("Enter the Number A: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Number B: ");
int NumberB = Convert.ToInt32(Console.ReadLine());
int exponentiation = Exponentiation(NumberA, NumberB);
Console.WriteLine("Answer: " + exponentiation);
  