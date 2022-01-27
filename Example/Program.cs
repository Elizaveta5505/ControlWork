// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

                    //    Бё (Норвегия)                     Хоф (Германия)
string[] stringArray = { "Bø", "Moscow", "London", "Wien", "Hof" };
foreach (string i in stringArray)
    Console.Write($"{i} ");
Console.Write("-> ");

string[] FormArray(string[] stringArray, int N)
{
    int lengthArray = 0; // создаём длину нового массива, чтобы не было пустых строк
    for (int i = 0; i < stringArray.Length; i++)
    {
        int length = stringArray[i].Length;
        if (length <= N) 
        {
            lengthArray++; // сколько строк будут удовлетворять условию, такой будет и размер
        }
    }
    string[] array = new string[lengthArray]; // новый массив соответствующего размера
    int k = 0;
    for (int j = 0; j < stringArray.Length; j++)
    {
        int length = stringArray[j].Length;
        if (length <= N)
        {
            array[k] = stringArray[j]; // добавляем в новый массив строки из старого массива, которые удовлетворяют условию
            k++;
        }
    }
    return array;
}

string[] array = FormArray(stringArray, 3);
foreach (string i in array)
    Console.Write($"{i} ");