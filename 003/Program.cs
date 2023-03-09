int[] GetSum(int[] array, int m)
{
    int n = array.Length;
    int[] t = new int[n - m + 1];
    int sum = 0;
    for (int i = 0; i < m; i++) sum+= array[i];
    int index = 0;
    t[index++] = sum;
    for (int i = 1; i <= n - m; i++)
    {
sum = sum - array[i-1] + array[i+1];
t[index++] = sum;
    }
    return t;
}
int [] CreateArray(int size) => new int[size];
string Print(int[] array) => $"[{string.Join(",", array)}]";
void FillA(ref int[] array) => array = array.Select(e => Random.Shared.Next(10)).ToArray();
int[] numbers = CreateArray(5);
FillA(ref numbers);
Console.WriteLine(Print(numbers));
int count = 2;
int []SumGroup = GetSum(numbers, count);
Console.WriteLine(Print(SumGroup));