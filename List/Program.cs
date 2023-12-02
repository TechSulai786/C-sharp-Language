namespace List_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(4);
            list.Add(5);
            list.Add(6);

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }

            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Orange");

            Console.WriteLine($"Number of fruits: {fruits.Count}");
            fruits.Remove("Banana");
            Console.WriteLine($"Number of fruits: {fruits.Count}");
            foreach (string i in fruits)
            {
                Console.WriteLine(i);
            }
            fruits.Clear();
            Console.WriteLine("List after Clear: " + string.Join(", ", fruits));
            
        }
    }
}
