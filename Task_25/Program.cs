Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());

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

degreeResult = RaiseToADegree(a, b);
Console.WriteLine("{0}, {1} -> {2:F6}", a, b, degreeResult);
