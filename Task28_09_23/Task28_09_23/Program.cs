// Task 1
// int[] numbers = { 1, 2, 3, 4, 5 };

// int sum = 0;

// foreach (int number in numbers)
// {
//     sum += number;
// }

// Console.WriteLine($"Massivdəki elementlərin cəmi: {sum}");

// Task 2
// string[] words = { "cat", "dog", "fish", "bird", "lion", "wolf", "frog" };

// Console.WriteLine("4-Hərfli Sözlər:");

// foreach (string word in words)
// {
//     if (word.Length == 4)
//     {
//         Console.WriteLine(word);
//     }
// }


//Task 3 

//int[] arr = new int[] {1, 3, 6, 7, 5, 9};

//int temp;

//for (int i = 0; i < arr.Length - 1; i++)

//    for (int j = i + 1; j < arr.Length; j++)

//        if (arr[i] < arr[j]) 
//        {

//            temp = arr[i];
//            arr[i] = arr[j];
//            arr[j] = temp;
//        }


//foreach(int value in arr)
//{
//    Console.Write(value + " ");
//}

//Optional ;) dersde verdiyiniz 2D masivin butun elementlerini
//       ekrana chixarir 

int[,] arr2d = {
                   {1, 2, 3},
                   {3, 4, 5},
                };
for (int i = 0; i < arr2d.GetLength(0); i++)
{
    for (int j = 0; j < arr2d.GetLength(1); j++)
    {
        Console.Write(arr2d[i, j]);
        Console.WriteLine();
    }
    Console.WriteLine();
}