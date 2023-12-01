public class GenericsClass<T>
{
    public T Data { get; set; }

    public void DisplayName()
    {
        Console.WriteLine($"Data is: {Data}");
    }
}

public class program
{
    public static void Main(string[] args)
    {
        GenericsClass<int> generics = new GenericsClass<int>();
        generics.Data = 45;
        generics.DisplayName();

        GenericsClass<string> strgenerics = new GenericsClass<string>();
        strgenerics.Data = "string.Empty";
        strgenerics.DisplayName();
    }
}
