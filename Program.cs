using System;
using static System.Console;

Clear();
WriteLine("Введите длину массива");
int a = int.Parse(ReadLine()!);
WriteLine("Ведите строки массива через Enter");
string [] array = Masiv(a);
WriteLine("Вывод");
WriteLine(String.Join("\n",Metod(array)));

string [] Masiv(int index)
{
    string [] res = new string[index];
    for(int i = 0; i < index; i++)
    {
        res[i] = ReadLine()!;
    }
    return res;
}

string [] Metod(string [] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if( array[i].Length < 4)
        {
            count++;
        }      
    }
    string [] res = new string[count];
    int p = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if( array[i].Length < 4)
        {
            res[p] = array[i];
            p++;
        }      
    }
    return res;
}