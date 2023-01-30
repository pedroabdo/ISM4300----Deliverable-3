//Author Pedro Nader
// Jan 30
// Deliverable 3
//The purpose of this code is to create a program that returns all even or odd numbers from an user inputted range

namespace ISM_4300___Deliverable_3;
class Program
{
    static void Main(string[] args)
    {

        Boolean done = false;
        while (!done)
        {
            try
            {
                Console.WriteLine("Enter an integer between 1 and 100");
                int range = int.Parse(Console.ReadLine());


                Console.WriteLine("Specify:'Even' or 'Odd'");
                string series = Console.ReadLine();

                if (range < 1 || range > 100)
                {
                    Console.WriteLine("Please enter a valid range");
                }
                else if (series == "Even")
                {
                    Console.WriteLine("You have selected all the " + series + " numbers between 0 and " + range + ". These numbers are:");
                    for (int i = 0; i <= range; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                    done = true;
                }
                else if (series == "Odd")
                {
                    Console.WriteLine("You have selected all the " + series + " numbers between 0 and " + range + ". These numbers are:");
                    for (int i = 1; i <= range; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                    done = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid Series option");
                }

            }
            catch
            {
                Console.WriteLine("Please enter a valid range");
            }
        }

        Console.ReadKey(true);


    }

}

