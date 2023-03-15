double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num,1);
    }
    return arr;
}

void ArrayPrinted(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + "; ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

double FindMax(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>max)
        {
            max = arr[i];
        }
    }
    return max;
}

double FindMin(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]<min)
        {
            min = arr[i];
        }
    }
    return min;
}

double[] newArray = CreateArrayRndInt(5, 10, 100);
ArrayPrinted(newArray);

double maximum = FindMax(newArray);
double minimum = FindMin(newArray);

double result = Math.Round(maximum+minimum, 1);

Console.WriteLine(result);
