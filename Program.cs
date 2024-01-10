/* [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

Console.Clear();
Console.WriteLine();
int MaxLength = 3; 

Console.ForegroundColor = ConsoleColor.Cyan;
string[] Array1 = { "Hello", "2", "world", ":-)" };
Result(Array1, MaxLength);

Console.ForegroundColor = ConsoleColor.Magenta;
string[] Array2 = { "1234", "1567", "-2", "computer science" };
Result(Array2, MaxLength);

Console.ForegroundColor = ConsoleColor.Green;
string[] Array3 = { "Russia", "Denmark", "Kazan" };
Result(Array3, MaxLength);
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();

int CountItems(string[] array, int max)
{
    int count = 0;                                      
    for (int i = 0; i < array.Length; i++)                
    {
        if (array[i].Length <= max) count++;              
    }
    return count;                                       
}

string[] NewArray(string[] array, int max)
{
    int newArrayLenght = CountItems(array, max);          
    string[] newArray = new string[newArrayLenght];     
    int newArrayIndex = 0;                              
    for (int i = 0; i < array.Length; i++)                
    {
        if (array[i].Length <= max)                       
        {
            newArray[newArrayIndex] = array[i];           
            newArrayIndex++;                            
        }
    }
    return newArray;                                    
}

void PrintArray(string[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write('"');
        System.Console.Write(array[i]);
        System.Console.Write('"');
        if (i < array.Length - 1) System.Console.Write(", ");
    }
    System.Console.Write("]");
}

void Result (string[] array, int max)
{
    string[] newArray = NewArray(array, max);
    PrintArray(array);
    System.Console.Write(" → ");
    PrintArray(newArray);
    System.Console.WriteLine();
}
