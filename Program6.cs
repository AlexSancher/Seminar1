int[] RandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void SwapArray(int[] array)
{
    int buf = 0;

    for (int i = 0; i < array.Length / 2; i++)
    {
        buf = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = buf;
    }

    ShowArray(array);
}

void SwapArray1(int[] array)
{
    int[] arr = new int[array.Length];

    for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
    {
        arr[i] = array[j];
    }

    ShowArray(arr);
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = RandomArray(size);

ShowArray(arr);

Console.WriteLine();
SwapArray(arr);
SwapArray1(arr);