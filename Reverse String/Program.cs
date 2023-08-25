// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Sulai");
Console.WriteLine("Enter any String: ");
string str = Console.ReadLine() ;
for (int i = str.Length - 1; i >= 0; i--)
{
    Console.Write(str[i]);
}