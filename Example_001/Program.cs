// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);

// for (int i = 2; i <= 10 ; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} X {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

// string text = "Калач - это традиционное русское печенье, которое имеет круглую форму и сладковатый вкус. Это печенье впервые появилось на Руси в древние времена, и с тех пор стало настоящей национальной гордостью в русской кухне.";

// string Replase(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int lenght = text.Length;
//     for (int i = 0; i < lenght; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replase(text, ' ', '|');

// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replase(text, 'к', 'К');
// Console.WriteLine(newText);

int [] arr = {1, 3, 5, 4, 6, 2, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i< count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);

SelectionSort(arr);
PrintArray(arr);