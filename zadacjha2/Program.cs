namespace zadacjha2
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
            Array.Sort(arr);
            Console.Write("The positions: ");
            BinarySearch(arr, target);

            Console.WriteLine("The array: ");
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
        }
        static void BinarySearch(int[] arr, int target)
        {
            List<int> positions = new List<int>();
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == target)
                {
                    positions.Add(mid);
                    int leftmid = mid - 1;
                    while (leftmid >= 0 && arr[leftmid] == target)
                    {
                        positions.Insert(0, leftmid);
                        leftmid--;
                    }

                    int rightmid = mid + 1;
                    while (rightmid < arr.Length && arr[rightmid] == target)
                    {
                        positions.Add(rightmid);
                        rightmid++;
                    }
                    break;
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                    right = mid - 1;
            }

            if (positions.Count > 0)
            {
                foreach (var i in positions)
                {
                    Console.Write(i+1 + " ");
                }
                Console.WriteLine();
                Console.WriteLine($"How many {target}s are there: {positions.Count}");
            }
            else
                Console.WriteLine("Ne e nameren");
        }
    }
}
