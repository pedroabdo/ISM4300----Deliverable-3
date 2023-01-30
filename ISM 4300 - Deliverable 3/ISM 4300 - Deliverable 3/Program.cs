//Author Pedro Nader
// Jan 30
// Deliverable 3
//The purpose of this code is to create a program that returns all even or odd numbers from an user inputted range

namespace ISM_4300___Deliverable_3;
class Program
{
    static void Main(string[] args)
    {
        //Setting the loop flag so it stops when done
        Boolean done = false;
        while (!done)
        {
            //Using try catch to make sure the input is valid
            try
            {
                Console.WriteLine("Enter an integer between 1 and 100");
                int range = int.Parse(Console.ReadLine());


                Console.WriteLine("Specify:'Even' or 'Odd'");
                string series = Console.ReadLine();

                //If the input is not in range it won't run the rest of the program and it will loop it back up to the input
                if (range < 1 || range > 100)
                {
                    Console.WriteLine("Please enter a valid range");
                }
                //Run this code if even
                else if (series == "Even")
                {
                    Console.WriteLine("You have selected all the " + series + " numbers between 0 and " + range + ". These numbers are:");
                    //Start summing two to I from 0 to get all even
                    for (int i = 0; i <= range; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                    //flag to stop loop
                    done = true;
                }
                else if (series == "Odd")
                {
                    Console.WriteLine("You have selected all the " + series + " numbers between 0 and " + range + ". These numbers are:");
                    //Start summing two to I from 1 to get all odd
                    for (int i = 1; i <= range; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                    //flag to stop loop
                    
                    done = true;
                }
                else
                {
                    //Error message
                    Console.WriteLine("Please enter a valid Series option");
                }

            }
            catch
            {
                    //Error message
           
                Console.WriteLine("Please enter a valid range");
            }
        }

        Console.ReadKey(true);


    }

}

