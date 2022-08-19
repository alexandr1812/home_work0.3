Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

string Cubing(int n)
{
    string result = "";
    for (int i = 1; i <= n; i++)
    {
        result += $"{Math.Pow(i, 3)} ";
    }
    return result;
}

Console.WriteLine(Cubing(n));