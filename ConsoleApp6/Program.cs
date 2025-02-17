namespace ConsoleApp6
{
    internal class Program
    {
        static void BubbleSort(List<Student> students)
        {
            int n = students.Count;
            for (int i = 0; i < n; i++)
            {
                bool swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (students[j].Age > students[j + 1].Age)
                    {
                        var temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }
        static void Main(string[] args)
        {
           List<Student> students = new List<Student>
           {
            new Student("Ivan", 16),
            new Student("Zhivko", 15),
            new Student("Petar", 17),
            new Student("Kris", 14)
           };

             Console.WriteLine("Uchenici predi sort:");
             foreach (var s in students)
             {
                 Console.WriteLine(s);
             }

             BubbleSort(students);

             Console.WriteLine("\nUch sled sort:");
             foreach (var s in students)
             {
                Console.WriteLine(s);
             }
        }
    }
}
