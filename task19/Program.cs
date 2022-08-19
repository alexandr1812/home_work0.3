Console.Clear();
int num = Convert.ToInt32(Console.ReadLine());
string copy = num.ToString();

string palindrome(string num)
{
    string copy = "";
    for (int i = num.Length - 1; i >= 0; i--)
    {
        copy += num[i];
    }
    return copy;
}

Console.WriteLine(palindrome(copy));
string res = palindrome(copy);

if (res == copy)
{
    Console.WriteLine(" -> да");
}
else
{
    Console.WriteLine(" -> нет");
}

// 14212 -> нет

// 12821 -> да

// 23432 -> да

