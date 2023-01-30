void InputString(string[] s)
{
    for (int i = 0; i < s.Length; i++)
    Console.Write(" " + s[i]);
}
string[] OutputString(string[] s)
{
    string[] mas = new string[s.Length];
    int k = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i].Length <= 3)
        {
            mas[k] = s[i];
            k = k + 1;
        }
    }
    if (k == 0)
    {
        mas[0] =("строк с дилнной меньше либо равной 3 не существует");
    }
    return mas;
}
Console.Clear();
Console.Write("Введите массив: ");
string [] s = Console.ReadLine().Split(" ");
InputString(s);
string [] vivod = OutputString(s);
for (int i = 0; i < vivod.Length; i++)
Console.Write(" " + vivod[i]);