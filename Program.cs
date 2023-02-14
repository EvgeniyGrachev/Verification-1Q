/* Контрольная работа по 1 четверти:
Написать программу, которая из имеющегося массива строк формирует массив из сторк, длинна которых меньше либо равна 3 символа.
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
*/

// Возвращает массив из size элементов, заполненных строками

string[] GetArray(int size)
{
    string[] res = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите строку любой длинны: ");
        res[i] = Console.ReadLine() ?? "";
    }
    return res;
}

// Возвращает массив с элементами, длинна которых меньше либо равна 3 символа

string[] GetNewArray(string[] ar)
{
    string[] newAr = new string[ar.Length];
    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i].Length <= 3)
            newAr[i] = ar[i];
    }
    newAr = (from word in newAr where word != null select word).ToArray();
    return newAr;
}