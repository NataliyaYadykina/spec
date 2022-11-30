// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести
// с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.
// ["hello", "2", "world", ":-)"] => ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] => ["-2"]
// ["Russia", "Denmark", "Kazan"] => []

// Fill source array and count find elements.
int FillSourceArray(string[] array, int countSymbols)
{
    int countFindElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Write element {i} in array: ");
        array[i] = Console.ReadLine();
        if (array[i].Length <= countSymbols)
        {
            countFindElements++;
        }
    }
    return countFindElements;
}

// Fill result array.
void FillResultArray(string[] sourceArray, string[] resultArray, int countSymbols)
{
    int countEditElement = 0;
    for(int i = 0; i < sourceArray.Length; i++)
    {
        if (sourceArray[i].Length <= countSymbols)
        {
            resultArray[countEditElement] = sourceArray[i];
            countEditElement++;
        }
    }
}

Console.Write("Write array length: ");
int n = Convert.ToInt32(Console.ReadLine());
int countSymbols = 3;

if(n > 0)
{
    string[] arr = new string[n];
    int lengthResultArray = FillSourceArray(arr, countSymbols);

    string[] resultArray = new string[lengthResultArray];
    FillResultArray(arr, resultArray, countSymbols);
    Console.WriteLine("Source array: [{0}]", string.Join(", ", arr));
    Console.WriteLine("Result array: [{0}]", string.Join(", ", resultArray));
}
else
{
    Console.WriteLine("Error! Try again. Write length > 0.");
}
