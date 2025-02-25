namespace awadasdwdqwdqw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the lenght of the arr: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.Write("Enter a target between 1 and 1000: ");
            int target = int.Parse(Console.ReadLine());

            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(1, 1000);
            }
            Console.Write("The positions: ");

            Search(arr, target);

            Console.WriteLine("The array: ");

            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
        }
        static void Search(int[] array, int target)
        {
            List<int> positions = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    positions.Add(i);
                }
            }
            if (positions.Count > 0)
            {
                foreach (var i in positions)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                Console.WriteLine($"How many {target}s are there: {positions.Count}");
            }
            else
                Console.WriteLine("Ne e nameren");
        }
    }
}
