// Напишите программу, которая задаёт массив из n элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите количество элементов массива: ");
int count = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int [] arr = new int[count];
for(int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(1, 100);
}
Console.Write('['+string.Join(", ", arr) + ']');