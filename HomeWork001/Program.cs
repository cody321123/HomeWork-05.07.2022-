int SumNumber(int value)
{
          int result = 0;
          while (value > 0)
          {
               result+= value % 10;
               value = value / 10;     
          }
          return result;                          
}

Console.Write("Введите число - ");

int num = Convert.ToInt32(Console.ReadLine());

int result = SumNumber(num);

Console.WriteLine(result);

