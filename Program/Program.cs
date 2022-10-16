string[] FirstArray = new string[7] {"Hello", ":-)", "computer", "5", "Russia", "1567", "Kazan"};
string[] SecondArray = new string[FirstArray.Length];

void FillArray(string[] FirstArray, string[] SecondArray)
{
    int count = 0;
    for (int i = 0; i < FirstArray.Length; i++)
    {
        if(FirstArray[i].Length <= 3)
        {
            SecondArray[count] = FirstArray[i];
            count++;
        }
	}
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(" " + array[i]);
	}
	Console.WriteLine();
}

FillArray(FirstArray, SecondArray);
PrintArray(SecondArray);