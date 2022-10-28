/* Напишите программу, которая задаёт массив из 
8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

/*
int [] array = new int [8];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0,99);
}

Console.WriteLine(string.Join(",", array ));
*/

// получить все 8 чисел за одно нажатие Enter от пользователя.подсказка: 
// использовать метод Split();*/


// Console.WriteLine("Введите элементы массива, разделяя их одним пробелом");

Console.WriteLine("Введите число : ");
string NumbersStr = Console.ReadLine();
string[] array = NumbersStr.Split();
Console.Write("[");
for (int i = 0; i < array.Length-1; i++) 
Console.Write(array[i]+", ");
Console.WriteLine(array[array.Length-1]+"]");
