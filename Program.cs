using static System.Console;

string? input1 = ReadLine();
string? input2 = ReadLine();

try
{
    int a = int.Parse(input1);
    int b = int.Parse(input2);
    WriteLine(a / b);
} catch (FormatException)
{
    WriteLine("wrong format !!!!!!!!!!!!!!!!");
}


// or


if (int.TryParse(input1, out int c) && int.TryParse(input2, out int d))
{
    WriteLine(c / d);
} else
{
    WriteLine("wrong format !!!!!!!!!!!!!!!!");
}
