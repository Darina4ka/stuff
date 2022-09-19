Console.Write("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());
  int Sum(int N)
  {
    int counter = Convert.ToString(N).Length;
    int advance = 0;
    int res = 0;

    for (int i = 0; i < counter; i++){
      advance = N - N % 10;
      res = res + (N - advance);
      N = N / 10;
    }
   return res;
  }
int sum = Sum(N);
Console.WriteLine("Сумма цифр в числе " + sum);