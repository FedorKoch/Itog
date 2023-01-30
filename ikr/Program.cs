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
return mas;
}
Console.Clear();
Console.Write("Введите массив: ");
string [] s = Console.ReadLine().Split(" ");
InputString(s);
string [] vivod = OutputString(s);