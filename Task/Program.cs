
Console.WriteLine("Ведите текст, чтобы напечатать его в рамке:");
string str = Console.ReadLine();

void WriteTextInAFrame(string text)
{
    Console.Clear();
    string strUpDown = "+";
    string strCentre = "| " + text + " |";
    for (int i = 0; i < text.Length + 2; i++)
    {
        strUpDown = strUpDown + '-';
    }
    strUpDown = strUpDown + '+';
    Console.WriteLine(strUpDown);
    Console.WriteLine(strCentre);
    Console.WriteLine(strUpDown);
}

WriteTextInAFrame(str);
