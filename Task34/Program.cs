int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr=new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min,max+1);
    }
    return arr;
}

void ArrayPrinted(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i<arr.Length-1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int CountEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2==0) count++;
    }
    return count;
}

Console.WriteLine("Input 3 numbers (two last must consist of 3 digits)");
int resize = Convert.ToInt32(Console.ReadLine());
int minimum = Convert.ToInt32(Console.ReadLine());
int maximum = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateArrayRndInt(resize,minimum,maximum);
ArrayPrinted(newArray);

int countEven = CountEvenNumbers(newArray);

Console.WriteLine(countEven);

