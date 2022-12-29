string[] Massiv(int size)
{
    Console.WriteLine("Введите слова");
    string [] array = new string [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Console.ReadLine();    
    }
    return array;
}

void PrintMassiv(string[] array)
{   int size = array.Length;
   for (int i = 0; i < size; i++)
   
        Console.Write($"{array[i]} ");
    Console.WriteLine();


}

string[] Choice(string [] array)
{
    int size = array.Length;
    int newSize = 0;

    for (int i = 0; i < size; i++)
    {
        if(array[i].Length < 4)
            newSize++;
    }
    string [] newArray = new string [newSize];
    int j = 0;
    for (int i = 0; i < size; i++)
    {
        if(array[i].Length < 4)
        {
            newArray[j] = array[i];
            j++; 
        }    
    }
    return newArray;

}

void PrintChoice(string[] newArray)
{   int size = newArray.Length;
   for (int i = 0; i < size; i++)
   
        Console.Write($"{newArray[i]} ");
    Console.WriteLine();    
   
}

Console.WriteLine("Введите количесто слов");
string [] array1 = Massiv(int.Parse(Console.ReadLine()));
PrintMassiv(array1);
string [] array2 = Choice(array1);
PrintChoice(array2);
