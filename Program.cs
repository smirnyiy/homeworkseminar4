//Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B (Math.Pow НЕ использовать)
//3, 5 -> 243 (3⁵)
//0, 0 - >1
//2, 4 -> 16
/*
int DegreeNum(int numA, int numB)
{
  int result = 1;
  for(int i=1; i <= numB; i++)
  {
    result = result * numA;
  }
  return result;
}

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int Degree = DegreeNum(numA, numB);
Console.WriteLine("Итог: " + Degree);
*/


//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumber(int num)
{ 
int count = Convert.ToString(num).Length;
int advance = 0;
int result = 0;

for (int i = 0; i < count; i++)
    {
      advance = num - num % 10;
      result = result + (num - advance);
      num = num / 10;
    }
return result;
}

int sumNumber = SumNumber(num);
Console.WriteLine("Сумма цифр в числе равна: " + sumNumber);
*/



//Напишите программу, которая создает массив заданного пользователем размера, заполняет массив элементами от 1 до 99 и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
/*
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());


int [] CreatRandArray (int n)
{
    int [] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(1,99);
    }
    return arr;
}

void PrintArray(int [] arr)
{
int count = arr.Length;
int i = 0;   
Console.Write("");
while(i < count)
  {
    Console.Write(arr[i]);
    i++;
    if (i < count){
      Console.Write(", ");
    }
  }
Console.Write("");
}

void PrintArray1(int [] arr)
{
int count = arr.Length;
int i = 0;    
Console.Write("->[");
while(i < count)
  {
    Console.Write(arr[i]);
    i++;
    if (i < count){
      Console.Write(", ");
    }
  }
Console.Write("]");
} 

int [] newArray = CreatRandArray(n);

PrintArray(newArray);
PrintArray1(newArray);
*/
 

