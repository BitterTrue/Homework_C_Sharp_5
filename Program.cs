//Задача 10:

Console.Clear();
Console.WriteLine("Введите трехзначное число");
int threeDigitNumber = int.Parse(Console.ReadLine());
threeDigitNumber = (threeDigitNumber % 100)/10;
Console.WriteLine($"вторая цифра этого числа {threeDigitNumber}");

//Задача 13:
Console.Clear();
Console.WriteLine("Введите число");
int thirdDigitNumber = int.Parse(Console.ReadLine());

if (thirdDigitNumber < 100)
{
  Console.WriteLine("Третьей цифры нет");
}
else if (thirdDigitNumber >= 100 && thirdDigitNumber < 1000)
{
  Console.WriteLine($"Третья цифра числа {thirdDigitNumber % 10}");
}
else if (thirdDigitNumber >= 1000 && thirdDigitNumber < 10000)
{
  Console.WriteLine($"Третья цифры этого числа {(thirdDigitNumber % 100)/10}");
}
else if (thirdDigitNumber >= 10000 && thirdDigitNumber < 100000)
{
  Console.WriteLine($"Третья цифра этого числа {(thirdDigitNumber % 1000)/100}");
}
//Задача 15:

Console.Clear();
Console.WriteLine("Введите номер дня недели");
int Num = int.Parse(Console.ReadLine());
if (Num < 6 && Num > 0)
{
Console.WriteLine("сегодня рабочий день");
}
else if (Num == 6 || Num ==7 )
{
  Console.WriteLine("сегодня выходной день");
}
else{
    Console.WriteLine($"вы ввели число {Num} , а ожидалось число от 1 до 7");
}