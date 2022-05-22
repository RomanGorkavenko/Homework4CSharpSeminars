int sum = 0;
int resNum = 2;
int number = 12;
for (int i = 0; i < resNum; i++)
{
    sum = sum + (number % 10);
    number = number / 10;
}
Console.WriteLine(sum);