string[] arrayFirst = new string[6] {"546", "pepega", "Kart_racing", "Pit", "99", "Final_Countdown"};
string[] arraySecond = new string[arrayFirst.Length];
int count = 0;
for (int i = 0; i < arrayFirst.Length; i++)
{
if(arrayFirst[i].Length <= 3)
    {
    arraySecond[count] = arrayFirst[i];
    count++;
    }
}
for (int i = 0; i < arraySecond.Length; i++)
{
    Console.Write($"{arraySecond[i]} ");
}
Console.WriteLine();
