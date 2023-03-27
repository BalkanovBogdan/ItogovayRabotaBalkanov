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
