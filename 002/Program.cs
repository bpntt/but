int[] GetSum(int[] array, int m)
{
    int n = array.Length;
    int[] t = new int[n - m + 1];
    int index = 0;
    for (int i = 0; i <= n - m; i++)
    {
        for (int j = i; j < i + m; j++)
        {
            t[index] += array[j];
        }
        index++;
    }
    return t;
}
int [] CreateArray(int size) => new int[size];
string Print(int[] array) => $"[{string.Join(",", array)}]";
void FillA(ref int[] array) => array = array.Select(e => Random.Shared.Next(10)).ToArray();
int[] numbers = CreateArray(8);
FillA(ref numbers);
Console.WriteLine(Print(numbers));
int count = 3;
int []SumGroup = GetSum(numbers, count);
Console.WriteLine(Print(SumGroup));