/* 1 
Console.WriteLine("Write Your number");
double n = Convert.ToInt64(Console.ReadLine());
PrintNumber1(n);
void PrintNumber1 (double n)
{
for (double i = -n; i < n + 1; i++)
{
    Console.Write($"{i}" + " ");
}
}
/* 2 
GetValumeByUser("Write Your number");
PrintNumber1(n);
int GetValumeByUser(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}
void PrintNumber1 (double n)
{
for (double i = -n; i < n + 1; i++)
{
    Console.Write($"{i}" + " ");
}
}
/* 3 
int n = GetValumeByUser("Write Your number");
PrintNumber1(n );
int  GetValumeByUser(string text)
{
    int value = 0;
    Boolean flag = false;
    do
    {
    Console.Write(text);
    string s = Console.ReadLine()!;
    flag = int.TryParse(s, out value) && value > 0;
    }
    while (!flag);
    return value;
    
}
void PrintNumber1 (double n)
{
for (double i = -n; i < n + 1; i++)
{
    Console.Write($"{i}" + " ");
}
}
/* 4 
int n = GetValumeByUser("Write Your number");
PrintNumber1(n );
Console.WriteLine(PrintNumber2(n));
string res = PrintNumber2(n);
File.WriteAllText("data.txt", res);
int  GetValumeByUser(string text)
{
    int value = 0;
    Boolean flag = false;
    do
    {
    Console.Write(text);
    string s = Console.ReadLine()!;
    flag = int.TryParse(s, out value) && value > 0;
    }
    while (!flag);
    return value;
    
}
void PrintNumber1 (double n)
{
for (double i = -n; i < n + 1; i++)
{
    Console.Write($"{i}" + " ");
}
}
string PrintNumber2 (double n)
{
    string output = string.Empty;
for (double i = -n; i < n + 1; i++)
{
    output+=($"{i}" + " ");
}
return output;
}
/* 5 */
int n = GetValumeByUser("Write Your number");
PrintNumber1(n );
Console.WriteLine(PrintNumber1(n));
string res = PrintNumber1(n);
File.WriteAllText("data.txt", res);
int  GetValumeByUser(string text)
{
    int value = 0;
    Boolean flag = false;
    do
    {
    Console.Write(text);
    string s = Console.ReadLine()!;
    flag = int.TryParse(s, out value) && value > 0;
    }
    while (!flag);
    return value;
    
}
string PrintNumber1 (double n)
{
    string output = "0";
for (double i = 1; i < n + 1; i++)
{
    output= $"{-i}" + output + $"{i}" + " ";
}
return output;
}