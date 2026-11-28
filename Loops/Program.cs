
using System;

class Program
{
    static void Main()
    {
        // =================================
        // 1. FOR LOOP
        // =================================

        // Runs 5 times.
        // Starts at 1 and increases by 1.
        Console.WriteLine("FOR LOOP");

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }


        // =================================
        // 2. WHILE LOOP
        // =================================

        // Runs while the condition is TRUE.
        Console.WriteLine("\nWHILE LOOP");

        int a = 1;

        while (a <= 5)
        {
            Console.WriteLine(a);
            a++;
        }


        // =================================
        // 3. DO WHILE LOOP
        // =================================

        // Runs at least once, even if condition is FALSE.
        Console.WriteLine("\nDO WHILE LOOP");

        int b = 1;

        do
        {
            Console.WriteLine(b);
            b++;
        }
        while (b <= 5);


        // =================================
        // 4. FOREACH LOOP
        // =================================

        // Used to read items from an array or collection.
        Console.WriteLine("\nFOREACH LOOP");

        string[] names = { "Ram", "Hari", "Sita" };

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }


        // =================================
        // 5. BREAK
        // =================================

        // Stops the loop completely.
        Console.WriteLine("\nBREAK");

        for (int i = 1; i <= 5; i++)
        {
            if (i == 3)
            {
                break;
            }

            Console.WriteLine(i);
        }


        // =================================
        // 6. CONTINUE
        // =================================

        // Skips the current iteration.
        Console.WriteLine("\nCONTINUE");

        for (int i = 1; i <= 5; i++)
        {
            if (i == 3)
            {
                continue;
            }

            Console.WriteLine(i);
        }


        // =================================
        // 7. NESTED LOOP
        // =================================

        // A loop inside another loop.
        Console.WriteLine("\nNESTED LOOP");

        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= 2; j++)
            {
                Console.WriteLine($"i = {i}, j = {j}");
            }
        }


        // =================================
        // 8. INFINITE LOOP (DO NOT RUN FOREVER)
        // =================================

        // Runs forever unless stopped.
        // Use break when you need to stop it.

        Console.WriteLine("\nINFINITE LOOP EXAMPLE");

        int count = 1;

        while (true)
        {
            Console.WriteLine(count);

            if (count == 3)
            {
                break;
            }

            count++;
        }
    }
}
