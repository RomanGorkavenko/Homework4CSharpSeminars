Console.Write("Введите число А: ");
string a = Console.ReadLine();

Console.Write("Введите число B: ");
string b = Console.ReadLine();

int degreeResult;

int RaiseToADegree(int number, int degreeOfNumber)
{
    int degree = 1;
    for (int i = 0; i < degreeOfNumber; i++)
    {
        degree *= number;
    }
    return degree;
}

bool LetterInNumbers(string let)
{
    int n = let.Length;
    bool yesNo = true;

    for (int i = 0; i < n; i++)
    {
        // if (Char.IsLetter(let[i]) == true || Char.IsSymbol(let[i]) == true)
        if (Char.IsDigit(let[i]) == false || int.Parse(let) == 0)
        {
            yesNo = false;
            return yesNo;
        }
    }
    return yesNo;
}

if (LetterInNumbers(a) == true && LetterInNumbers(b) == true)
{
    int aInt = int.Parse(a);
    int bInt = int.Parse(b);
    degreeResult = RaiseToADegree(aInt, bInt);
    Console.WriteLine("{0} в степени {1} = {2}", aInt, bInt, degreeResult);
}
else Console.WriteLine("{0}, {1} -> Некорректный ввод!\nВедите цисла от 1 или равные 1", a, b);
