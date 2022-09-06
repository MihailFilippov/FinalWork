//_____________________________________________
//__________________Блок методов_______________
//_____________________________________________
void SecondArrayWithIF(string[] arrayFirst, string[] arraySecond)
{
    int size = arrayFirst.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
    if(arrayFirst[i].Length <= 3)
        {
        arraySecond[count] = arrayFirst[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//_____________________________________________
//__________________Блок кода__________________
//_____________________________________________

void Example001()
{
    string[] arrayFirst = new string[6] {"546", "pepega", "Kart_racing", "Pit", "99", "Final_Countdown"};
    string[] arraySecond = new string[arrayFirst.Length];
    SecondArrayWithIF(arrayFirst, arraySecond);
    PrintArray(arraySecond);
}

//_____________________________________________
//__________________Блок вызова________________
//_____________________________________________
Example001();