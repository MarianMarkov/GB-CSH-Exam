// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
void CreateArray(string[] array)
{   
    var random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int length = random.Next(1,10);
        array[i] = new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        Console.Write(array[i] + " ");
    }
}

string[] array = new string[8];
CreateArray(array);
PrintArray(array);