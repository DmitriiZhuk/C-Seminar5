/*
Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму четных элементов, 
стоящих на нечётных позициях (позиция - индекс элемента в массиве).
[3, 7, 23, 12] -> 12
[4, 6, 8, 1, 4] -> 6
*/

//1 Создаю массив
Console.Write("Введите размер массива: ");
int arrNum = Convert.ToInt32(Console.ReadLine());	
int[] numbersArray = new int[arrNum];

// 2 Заполняю массив случайными числами
// и показываю сумму четных элементов, стоящих на нечётных позициях.
Random rnd = new Random();
int sum = 0;
for (int i = 0; i < arrNum; i++)
{
    numbersArray[i] = rnd.Next(1, 10000);
    if (numbersArray[i] % 2 == 0 && i % 2 != 0) { sum = sum + numbersArray[i]; }
}
Console.WriteLine("Содержимое  массива = " + string.Join(" ", numbersArray));
Console.WriteLine("Сумма четных элементов, стоящих на нечётных позициях  = " + sum);

