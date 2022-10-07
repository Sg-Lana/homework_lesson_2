//Задача 3: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет. Не использовать строки для расчета.

//645 -> 5
//78 -> третьей цифры нет
//326792 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <100)
{
    Console.WriteLine("в числе нет третьей цифры");
}
else
while(number >= 1000)
{
	number = (number/10);// убираем один знак с конца
    if (number <=1000 & number >=100)
    {
    number = number % 10;
    Console.WriteLine($"третья цифра заданного числа {number}");
    }
}

