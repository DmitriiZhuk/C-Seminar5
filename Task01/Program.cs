/*
Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

//1 Создаю массив
Console.Write("Введите размер массива: ");
int arrNum = Convert.ToInt32(Console.ReadLine());
int[] numbersArray = new int[arrNum];

// 2 Заполняю массив случайными положительными трёхзначными числами
// и показываю количество чётных чисел в массиве.
Random rnd = new Random();
int counter = 0;
for (int i = 0; i < arrNum; i++)
{
    numbersArray[i] = rnd.Next(100, 1000);
    if (numbersArray[i] % 2 == 0) { counter++; }
}
Console.WriteLine("Содержимое  массива = " + string.Join(" ", numbersArray));
Console.WriteLine("Количество четных чисел = " + counter);
