//Define duplicates
int[] array = new int[] { 1, 2, 3, 4, 5, 6, 1, 7, 8, 9 };

for (int i = 0; i < array.Length; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[i] == array[j])
        {
            Console.WriteLine(array[i]);
        }
    }
}


//Output without duplicate value
var array1 = new int[] { 2, 3, 3, 4, 1, 2, 5 };
var distinct1 = array1.Distinct().ToArray();

Console.WriteLine(String.Join(",", distinct1));


