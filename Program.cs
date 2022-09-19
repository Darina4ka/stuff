int Exponentiation(int A, int B)
{
  int res = 1;
  for(int i=1; i <= B; i++)
  {
    res = res * A;
  }
    return res;
}
  Console.Write("Введите число A ");
  int A = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B ");
  int B = Convert.ToInt32(Console.ReadLine());
  int power = Exponentiation(A, B);
  Console.WriteLine(power);