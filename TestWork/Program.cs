// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// ["1234", "1567", "-2", "computer science"] -> ["-2"]

string[] StringsUpToThree(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            size++;
        }
    }
    
    string[] newArray = new String[size];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;
}

Console.WriteLine("Введите строки:");

string[] startArray = new String[6];
for (int i = 0; i < startArray.Length; i++)
    startArray[i] = Console.ReadLine();

Console.Write("Итоговый массив: ");

string[] finishArray = StringsUpToThree(startArray);
int size = finishArray.Length;
for (int i = 0; i < size; i++)
{
    if (i == size - 1) 
        Console.Write(finishArray[i] + ".");
    else
        Console.Write(finishArray[i] + ", ");
}