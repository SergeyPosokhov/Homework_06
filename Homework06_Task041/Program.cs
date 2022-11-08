//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] array = new int[m];

void FillArray(int[] array)
{
    int i = 0;
    while (i < m)
    {
        Console.Write($"Введите элемент массива с индексом {i}:  ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }
    Console.WriteLine();
    Console.Write("[");
    foreach (int elem in array)
    {
        Console.Write("{0}", $"{elem} ");
    }
    Console.WriteLine("]");
}
void PrintArray(int [] arr)
{
    int qty = 0;

    for (int i = 0; i < m; i++)
    {
        if (array [i] > 0)
        {
           qty ++; 
        }
    }
    Console.WriteLine($"Количество чисел больше 0 равно {qty} ");


}
//Console.WriteLine();
FillArray(array);
PrintArray(array);

