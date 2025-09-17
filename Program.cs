namespace basisprogrammering_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChangeIntArrayLoop();
        }
        static void ChangeIntArrayLoop()
        {
            int[] numbers = { 12, 33, 532, 145, 1, 4565, 1 };

            Console.WriteLine("Commands: c=change, p=print, q=quit");

            while (true)
            {
                Console.Write("\n[c/p/q]: ");
                string input = Console.ReadLine();

                if (input == "q")
                {
                    Console.WriteLine("exiting...");
                    break;
                }

                if (input == "p")
                {
                    PrintIntsArray(numbers);
                    continue;
                }

                if (input == "c")
                {
                    Console.WriteLine($"Which index do your want to change?? (0..{numbers.Length - 1})");
                    if (!int.TryParse(Console.ReadLine(), out int index) ||
                        index < 0 || index >= numbers.Length)
                    {
                        Console.WriteLine("Invalid index!");
                        continue;
                    }

                    Console.Write($"new value for index {index}: ");
                    if (!int.TryParse(Console.ReadLine(), out int newValue))
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }

                    numbers[index] = newValue;
                    Console.WriteLine("Array updated:");
                    PrintIntsArray(numbers);
                }
                else
                {
                    Console.WriteLine("Unkown command use: c/p/q.");
                }
            }
        }

        static void PrintIntsArray(int[] array)
        {
            foreach (int n in array)
            {
                Console.WriteLine(n);
            }
        }      
        static void PrintIntsArray()
        {
            Console.WriteLine("int array:");
            // Opgavens array
            int[] numbers = { 12, 33, 532, 145, 1, 4565, 1 };

            // 1) Skriv værdien af det femte element (index 4)
            Console.WriteLine($"5. element: {numbers[4]}");

            // 2) Ændr værdien af det tredje element (index 2) til 36562
            numbers[2] = 36562;

            // 3) Skriv alle ints ud – først med for, så med foreach
            Console.WriteLine("\nAlle tal (for):");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Index {i}: {numbers[i]}");
            }

            Console.WriteLine("\nAlle tal (foreach):");
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
        }

        static void PrintStringArray()
        {

            Console.WriteLine("string array:");
            // Mindst 10 navne
            string[] names =
            {
                "Dee","Gene","Steve","Mustaine","Alan",
                "Helmut","Olve","Stian","Mr.Mouser","Big Mike"
            };

            // 1) Skriv værdien af det femte element (index 4)
            Console.WriteLine($"5. navn: {names[4]}");

            // 2) Ændr værdien af det tredje element (index 2) til "Mario"
            names[2] = "Mario";

            // 3) Skriv alle navnene – for og foreach
            Console.WriteLine("\nAlle navne (for):");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Index {i}: {names[i]}");
            }

            Console.WriteLine("\nAlle navne (foreach):");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
