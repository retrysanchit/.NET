using System;

class Program
{
    static void Main(string[] args)
    {
        // =====================================
        // 1. SIMPLE IF STATEMENT
        // =====================================

        int age = 20;

        // Executes only when the condition is TRUE.
        if (age >= 18)
        {
            Console.WriteLine("You are an adult.");
        }


        // =====================================
        // 2. IF - ELSE STATEMENT
        // =====================================

        int number = 7;

        // If condition is TRUE, execute if block.
        // Otherwise, execute else block.
        if (number % 2 == 0)
        {
            Console.WriteLine("Even number");
        }
        else
        {
            Console.WriteLine("Odd number");
        }


        // =====================================
        // 3. IF - ELSE IF - ELSE
        // =====================================

        int marks = 75;

        // Checks conditions from top to bottom.
        // First TRUE condition gets executed.
        if (marks >= 90)
        {
            Console.WriteLine("Grade A");
        }
        else if (marks >= 75)
        {
            Console.WriteLine("Grade B");
        }
        else if (marks >= 60)
        {
            Console.WriteLine("Grade C");
        }
        else
        {
            Console.WriteLine("Fail");
        }


        // =====================================
        // 4. NESTED IF
        // =====================================

        int userAge = 22;
        bool hasLicense = true;

        // An if statement inside another if.
        if (userAge >= 18)
        {
            if (hasLicense)
            {
                Console.WriteLine("You can drive.");
            }
            else
            {
                Console.WriteLine("You need a driving license.");
            }
        }
        else
        {
            Console.WriteLine("You are too young to drive.");
        }


        // =====================================
        // 5. SWITCH STATEMENT
        // =====================================

        int day = 3;

        // Switch checks one value against multiple cases.
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;

            case 2:
                Console.WriteLine("Tuesday");
                break;

            case 3:
                Console.WriteLine("Wednesday");
                break;

            case 4:
                Console.WriteLine("Thursday");
                break;

            case 5:
                Console.WriteLine("Friday");
                break;

            default:
                // Runs when no case matches.
                Console.WriteLine("Invalid day");
                break;
        }


        // =====================================
        // 6. SWITCH WITH STRING
        // =====================================

        string role = "admin";

        switch (role)
        {
            case "admin":
                Console.WriteLine("Full access");
                break;

            case "user":
                Console.WriteLine("Normal access");
                break;

            case "guest":
                Console.WriteLine("Limited access");
                break;

            default:
                Console.WriteLine("Unknown role");
                break;
        }


        // =====================================
        // 7. SWITCH EXPRESSION (MODERN C#)
        // =====================================

        int month = 2;

        // Switch expression returns a value.
        string monthName = month switch
        {
            1 => "January",
            2 => "February",
            3 => "March",
            4 => "April",
            _ => "Invalid month"
        };

        Console.WriteLine(monthName);


        // =====================================
        // 8. TERNARY OPERATOR (?:)
        // =====================================

        int ageCheck = 17;

        // Short form of if-else.
        // condition ? valueIfTrue : valueIfFalse
        string result = ageCheck >= 18 ? "Adult" : "Minor";

        Console.WriteLine(result);


        // =====================================
        // 9. LOGICAL AND (&&)
        // =====================================

        int myAge = 25;
        bool hasId = true;

        // BOTH conditions must be TRUE.
        if (myAge >= 18 && hasId)
        {
            Console.WriteLine("Entry allowed");
        }


        // =====================================
        // 10. LOGICAL OR (||)
        // =====================================

        bool isAdmin = false;
        bool isManager = true;

        // AT LEAST ONE condition must be TRUE.
        if (isAdmin || isManager)
        {
            Console.WriteLine("You have permission");
        }


        // =====================================
        // 11. LOGICAL NOT (!)
        // =====================================

        bool isLoggedIn = false;

        // ! changes TRUE to FALSE and FALSE to TRUE.
        if (!isLoggedIn)
        {
            Console.WriteLine("Please login first");
        }


        // =====================================
        // 12. PATTERN MATCHING (IS)
        // =====================================

        object value = 100;

        // Checks whether value is an integer.
        if (value is int)
        {
            Console.WriteLine("Value is an integer");
        }

        // Checks type AND stores the converted value.
        if (value is int actualNumber)
        {
            Console.WriteLine(actualNumber);
        }


        // =====================================
        // 13. SWITCH WITH PATTERN MATCHING
        // =====================================

        int score = 85;

        string grade = score switch
        {
            >= 90 => "A",
            >= 80 => "B",
            >= 70 => "C",
            >= 60 => "D",
            _ => "F"
        };

        Console.WriteLine("Grade: " + grade);


        // =====================================
        // 14. NULL COALESCING (??)
        // =====================================

        string? username = null;

        // If username is null, use Guest.
        // Otherwise, use the actual username.
        string displayName = username ?? "Guest";

        Console.WriteLine(displayName);


        // =====================================
        // 15. NULL CONDITIONAL (?.)
        // =====================================

        string? name = null;

        // Access Length only if name is not null.
        int? length = name?.Length;

        Console.WriteLine(length);


        // =====================================
        // 16. BREAK STATEMENT
        // =====================================

        // Break immediately stops the loop.
        for (int i = 1; i <= 5; i++)
        {
            if (i == 3)
            {
                break;
            }

            Console.WriteLine(i);
        }


        // =====================================
        // 17. CONTINUE STATEMENT
        // =====================================

        // Continue skips the current iteration.
        for (int i = 1; i <= 5; i++)
        {
            if (i == 3)
            {
                continue;
            }

            Console.WriteLine(i);
        }


        // =====================================
        // 18. RETURN STATEMENT
        // =====================================

        // Return exits the current method.
        // This example uses another method below.
        Console.WriteLine(CheckNumber(10));
    }


    // A method that returns a decision result.
    static string CheckNumber(int number)
    {
        if (number > 0)
        {
            return "Positive number";
        }
        else if (number < 0)
        {
            return "Negative number";
        }

        return "Zero";
    }
}
