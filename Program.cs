namespace basisprogrammering_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintIntsArray();
            PrintStringArray();
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
