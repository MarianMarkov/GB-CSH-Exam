// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
var Alph = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
void CreateArraySmart(string[] array)
{   
    var random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int lenght = random.Next(1,10);
        array[i] = new string(Enumerable.Repeat(Alph, lenght).Select(s => s[random.Next(s.Length)]).ToArray());
    }
}

void CreateArraySimple(string[] array)
{   
    var random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int lenght = random.Next(1,10);
        for (int j = 0; j < lenght; j++)
        {
            int letter = random.Next(1,62);
            array[i] = array[i] + Alph[letter];
        }
        
    }
}

void CreateArrayManual(string[] array)
{   
    for (int i = 0; i < array.GetLength(0); i++)
    {
    Console.Write($"Значение {i + 1}го элемента: ");
    array[i] = Console.ReadLine()!;  
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        Console.Write($"[{array[i]}] ");
    }
}

void M(string[] array)
{
    Console.WriteLine("В программе представлено три способа создания массива: \n 1. CreateArraySmart - оптимизированный способ, использующий определенный функционал языка \n 2. CreateArraySimple - простой и примитивный способ \n 3. CreateArrayManual - ручной ввод массива");
    Console.Write("Укажите цифру желаемого способа создания массива: ");
    int number = int.Parse(Console.ReadLine()!);
    
    if (number == 1)
    {
        CreateArraySmart(array);
    }
    else if (number == 2)
    {
        CreateArraySimple(array);
    }
    else if (number == 3)
    {
        CreateArrayManual(array);
    }
    else
    {
        Console.WriteLine("УКАЗАНО НЕВЕРНОЕ ЗНАЧЕНИЕ");
        M(array);
    }
}

string[] array = new string[5];
M(array);
Console.WriteLine("Изначальный массив: ");
PrintArray(array);