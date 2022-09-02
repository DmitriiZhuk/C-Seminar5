/*
Задача 3*: Задайте массив натуральных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

//1 Создаю массив
Console.Write("Введите размер массива: ");
int arrNum = Convert.ToInt32(Console.ReadLine());	
int[] numbersArray = new int[arrNum];

// 2 Заполняю массив случайными числами
Random rnd = new Random();
for (int i = 0; i < arrNum; i++)
{
    numbersArray[i] = rnd.Next(1, 10000);
}

// 3 Нахожу макс и мин итерацией
int maxNum = numbersArray[0];
int minNum = numbersArray[0];

for (int i = 0; i < arrNum; i++)
{
    if (numbersArray[i] > maxNum)
    {
        maxNum = numbersArray[i];
    }

    if (numbersArray[i] < minNum)
    {
        minNum = numbersArray[i];
    }
}

// 4 Вывожу всё на экран	
Console.WriteLine("Содержимое массива = " + string.Join(" ", numbersArray));
Console.WriteLine("Макс число в массиве  = " + maxNum);
Console.WriteLine("Мин число в массиве  = " + minNum);
Console.WriteLine("Разница между макс и мин  = " + (maxNum - minNum));