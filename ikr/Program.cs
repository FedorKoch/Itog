void InputString(string[] s)
{
for (int i = 0; i < s.Length; i++)
Console.Write(" " + s[i]);
}
Console.Clear();
Console.Write("Введите массив: ");
string [] s = Console.ReadLine().Split(" ");
InputString(s);