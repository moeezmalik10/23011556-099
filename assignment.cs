using System;

class evenodd
{
    public static void program()
    {
        Console.WriteLine("Enter Number");
        int a = int.Parse(Console.ReadLine());
        if (a % 2 == 0)
            Console.WriteLine("Number is Even");
        else
            Console.WriteLine("Number is Odd");
    }
}

class calculater
{
    public static void Run()
    {
        Console.WriteLine("Basic Calculator \nEnter Option \n1. Addition \n2. Subtraction \n3. Multiplication \n4. Division");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter First Number");
        int ab = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        int ac = int.Parse(Console.ReadLine());
        switch (b)
        {
            case 1:
                Console.WriteLine("Result: " + (ab + ac));
                break;
            case 2:
                Console.WriteLine("Result: " + (ab - ac));
                break;
            case 3:
                Console.WriteLine("Result: " + (ab * ac));
                break;
            case 4:
                Console.WriteLine("Result: " + (ab / ac));
                break;
            default:
                Console.WriteLine("Invalid Option");
                break;
        }
    }
}

class grade
{
    public static void grading()
    {
        Console.WriteLine("Grade Check \nEnter Marks");
        int x = int.Parse(Console.ReadLine());
        if (x > 85)
            Console.WriteLine("Grade A");
        else if (x <= 85 && x > 70)
            Console.WriteLine("Grade B");
        else if (x <= 70 && x > 55)
            Console.WriteLine("Grade C");
        else if (x <= 55 && x > 40)
            Console.WriteLine("Grade D");
        else
            Console.WriteLine("Grade F");
    }
}

class natural
{
    public static void sum()
    {
        int n = 0;
        Console.WriteLine("Sum of Natural Numbers\nEnter Number");
        int z = int.Parse(Console.ReadLine());
        for (int i = 1; i <= z; i++)
        {
            n += i;
        }
        Console.WriteLine("Result " + n);
    }
}

class table
{
    public static void tab()
    {
        Console.WriteLine("Table \nEnter Number:");
        int y = int.Parse(Console.ReadLine());
        for (int s = 1; s <= 10; s++)
        {
            Console.WriteLine(y + " * " + s + " = " + (s * y));
        }
    }
}

class factorial
{
    public static void fact()
    {
        int n = 1;
        Console.WriteLine("Factorial\nEnter Number");
        int z = int.Parse(Console.ReadLine());
        for (int i = 1; i <= z; i++)
        {
            n *= i;
        }
        Console.WriteLine("Result " + n);
    }
}

class reverse
{
    public static void reve()
    {
        Console.WriteLine("Reverse Number\nEnter Number");
        int z = int.Parse(Console.ReadLine());
        int rev = 0;
        while (z > 0)
        {
            rev = rev * 10 + z % 10;
            z /= 10;
        }
        Console.WriteLine("Reverse Number: " + rev);
    }
}

class arraymaxmin
{
    public static void find()
    {
        int[] arr = new int[10];
        Console.WriteLine("Enter 10 numbers:");
        for (int i = 0; i < 10; i++)
            arr[i] = int.Parse(Console.ReadLine());
        int max = arr[0], min = arr[0];
        for (int i = 1; i < 10; i++)
        {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
        }
        Console.WriteLine("Maximum: " + max);
        Console.WriteLine("Minimum: " + min);
    }
}

class arrayevenodd
{
    public static void count()
    {
        int[] arr = new int[10];
        int even = 0, odd = 0;
        Console.WriteLine("Enter 10 numbers:");
        for (int i = 0; i < 10; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            if (arr[i] % 2 == 0)
                even++;
            else
                odd++;
        }
        Console.WriteLine("Even Numbers: " + even);
        Console.WriteLine("Odd Numbers: " + odd);
    }
}

class arraysearch
{
    public static void search()
    {
        int[] arr = new int[10];
        Console.WriteLine("Enter 10 numbers:");
        for (int i = 0; i < 10; i++)
            arr[i] = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number to search:");
        int num = int.Parse(Console.ReadLine());
        bool found = false;
        for (int i = 0; i < 10; i++)
        {
            if (arr[i] == num)
            {
                found = true;
                break;
            }
        }
        if (found)
            Console.WriteLine("Number found in array");
        else
            Console.WriteLine("Number not found in array");
    }
}

class assignment
{
    static void Main()
    {
        Console.WriteLine("Select Program (1-10):");
        Console.WriteLine("1. Even or Odd");
        Console.WriteLine("2. Calculator");
        Console.WriteLine("3. Grade Check");
        Console.WriteLine("4. Sum of Natural Numbers");
        Console.WriteLine("5. Table of Number");
        Console.WriteLine("6. Factorial");
        Console.WriteLine("7. Reverse Number");
        Console.WriteLine("8. Array Max and Min");
        Console.WriteLine("9. Array Even and Odd Count");
        Console.WriteLine("10. Array Search Element");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                evenodd.program();
                break;
            case 2:
                calculater.Run();
                break;
            case 3:
                grade.grading();
                break;
            case 4:
                natural.sum();
                break;
            case 5:
                table.tab();
                break;
            case 6:
                factorial.fact();
                break;
            case 7:
                reverse.reve();
                break;
            case 8:
                arraymaxmin.find();
                break;
            case 9:
                arrayevenodd.count();
                break;
            case 10:
                arraysearch.search();
                break;
            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
}
