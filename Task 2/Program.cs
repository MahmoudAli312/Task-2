namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            while (true)
            {

                Console.WriteLine("\nMenu options:");
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("Q - Quit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine()?.ToLower();

                if (choice == "p")
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("[] - the list is empty");
                    }
                    else
                    {
                        Console.Write("[ ");
                        foreach (var num in numbers)
                        {
                            Console.Write(num + " ");
                        }
                        Console.WriteLine("]");
                    }
                }
                else if (choice == "a")
                {
                    Console.Write("Enter an integer to add: ");
                    if (int.TryParse(Console.ReadLine(), out int num))
                    {
                        numbers.Add(num);
                        Console.WriteLine($"{num} added");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                    }
                }
                else if (choice == "m")
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to calculate the mean - no data");
                    }
                    else
                    {
                        int sum = 0;
                        foreach (var num in numbers)
                        {
                            sum += num;
                        }
                        double mean = (double)sum / numbers.Count;
                        Console.WriteLine($"The mean is {mean:F2}");
                    }
                }
                else if (choice == "s")

                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to determine the smallest number - list is empty");
                    }
                    else
                    {
                        int smallest = numbers[0];
                        foreach (var num in numbers)
                        {
                            if (num < smallest)
                            {
                                smallest = num;
                            }
                        }
                        Console.WriteLine($"The smallest number is {smallest}");
                    }

                else if (choice == "l")
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to determine the largest number - list is empty");
                    }
                    else
                    {
                        int largest = numbers[0];
                        foreach (var num in numbers)
                        {
                            if (num > largest)
                            {
                                largest = num;
                            }
                        }
                        Console.WriteLine($"The largest number is {largest}");
                    }
                }
                else if (choice == "q")
                {
                    Console.WriteLine("Goodbye");
                    break;
                }
                else
                {
                    Console.WriteLine("Unknown selection, please try again");
                }
            }
        }
    }
}
    
