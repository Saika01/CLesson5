// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void ArrayPrinted(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int[] Multiplication(int[] arr)
{
    int size = arr.Length / 2 + arr.Length % 2;
    int[] newArray = new int[size];
    if (size % 2 == 0)
    {
        for (int i = 0; i < size; i++)
        {
            newArray[i] = arr[i] * arr[arr.Length - i - 1];
        }
    }
    else
    {
        for (int i = 0; i < size-1; i++)
        {
            newArray[i] = arr[i] * arr[arr.Length - i - 1];
        }
        newArray[size-1] = arr[arr.Length/2];
    }
    return newArray;
}

int[] array = CreateArrayRndInt(5, -2, 5);
ArrayPrinted(array);
int[] newArr = Multiplication(array);
ArrayPrinted(newArr);
