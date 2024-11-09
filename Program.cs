using System.Linq;


static void PrintFibonacci(int n)
{
    int first = 0, second = 1, next;

    if (n >= 1)
        Console.Write(first + " ");
    if (n >= 2)
        Console.Write(second + " ");

    for (int i = 3; i <= n; i++)
    {
        next = first + second;
        Console.Write(next + " ");
        first = second;
        second = next;
    }
}


//--------------------------------------------------------------
double balance = 0;
while (true)
{
    Console.WriteLine("Main Menu");
    Console.WriteLine("1. Task 2 (Jagged Array)");
    Console.WriteLine("2. Exercise 1:");
    Console.WriteLine("3. Exercise 2: Bank System");
    Console.WriteLine("4. Exercise 3: Students");
    Console.WriteLine("5. Fibonacci");
    Console.WriteLine("6. Exit");



    int ch = 0;
    Console.WriteLine("Please Enter your Choice");
    ch = Convert.ToInt32(Console.ReadLine());
    switch (ch)
    {
        case 1:
            Console.WriteLine("Difference between Jagged arrays and Rectangular aarays:");
            Console.WriteLine("-- Rectangular Arrays: are uniform; have the same num. of columns in each row");
            Console.WriteLine("-- Jagged Arrays: are non-uniform; varying num. of columns in each row \n Example:");

            int[][] exArray = new int[3][];
            exArray[0] = new int[] { 1, 2 };
            exArray[1] = new int[] { 3, 4, 5 };
            exArray[2] = new int[] { 6, 7, 8, 9 };

            for (int i = 0; i < exArray.Length; i++)
            {
                for (int j = 0; j < exArray[i].Length; j++)
                {
                    Console.Write(exArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            break;
        case 2:
            int exno = 0;
            while (true)  
            {
                Console.WriteLine("1. Sum of 2 nums");
                Console.WriteLine("2. Eligibility for voting");
                Console.WriteLine("3. Display the quadrant");
                Console.WriteLine("4. Display the type of triangle");
                Console.WriteLine("5. Electricity bill.");
                Console.WriteLine("6. Exit");

                Console.WriteLine("Enter the Question Number:");
                exno = Convert.ToInt32(Console.ReadLine());
                switch (exno)
                {
                    case 1:
                        Console.WriteLine("1. Sum of 2 nums");
                        int fnum = 0, snum = 0, sresult = 0;
                        Console.WriteLine("Enter First Num ");
                        fnum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Second Num ");
                        snum = Convert.ToInt32(Console.ReadLine());

                        sresult = fnum + snum;
                        Console.WriteLine($"The Result is : {sresult}");
                        break;

                    case 2:
                        Console.WriteLine("2. Eligibility for voting");
                        Console.WriteLine("Please Enter Student Age:");
                        int age = Convert.ToInt32(Console.ReadLine());
                        if (age >= 18)
                            Console.WriteLine("Eligible for voting");
                        else
                            Console.WriteLine("Not Eligible for voting");

                        break;

                    case 3:
                        int x, y;
                        Console.WriteLine("3. Display the quadrant");
                        Console.WriteLine("Please Enter the Coordinates (x,y) \n x:");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("y:");
                        y = Convert.ToInt32(Console.ReadLine());

                        if (x == 0 || y == 0)
                            Console.WriteLine("The point lies on an axis.");
                        else if (x > 0 && y > 0)
                            Console.WriteLine("Quadrant I");
                        else if (x < 0 && y > 0)
                            Console.WriteLine("Quadrant II");
                        else if (x < 0 && y < 0)
                            Console.WriteLine("Quadrant III");
                        else
                            Console.WriteLine("Quadrant IV");
                        break;

                    case 4:
                        Console.WriteLine("4. Display the type of triangle");
                        Console.WriteLine("Please Enter Triangle sides");
                        int s1, s2, s3;
                        Console.WriteLine("First Side ");
                        s1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Second Side ");
                        s2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Third Side ");
                        s3 = Convert.ToInt32(Console.ReadLine());

                        if (s1 + s2 > s3 && s1 + s3 > s2 && s2 + s3 > s1)
                        {
                            if (s1 == s2 && s1 == s3)
                                Console.WriteLine("Equilateral Triangle");
                            else if ((s1 == s2 && s1 != s3) || (s1 == s3 && s1 != s2) || (s2 == s3 && s1 != s2))
                                Console.WriteLine("Isosceles Triangle");
                            else if ((s1 * s1) + (s2 * s2) == (s3 * s3))
                                Console.WriteLine("Right Triangle");
                        }
                        else
                            Console.WriteLine("Not a Triangle");
                        break;

                    case 5:
                        try
                        {
                            Console.WriteLine("5. Electricity bill.");
                            //Units Consumed     Charge per unit
                            //Less than 300       1.5
                            //Less than 450       2
                            //More than 450       2.5
                            //10% will be added as surcharge if units consumed exceed 600 watts.

                            Console.WriteLine("Please Enter The Consumed Units for this month:");
                            int unCon = Convert.ToInt32(Console.ReadLine());
                            double Fees = 0.0;
                            if (unCon < 0)
                            {
                                throw new InvalidInputException("Units consumed cannot be negative.");
                            }

                            if (unCon < 300)
                            {
                                Fees = unCon * 1.5;
                                Console.WriteLine($"The Bill Fees = {Fees}");
                            }
                            else if (unCon <= 450)
                            {
                                Fees = unCon * 2.0;
                                Console.WriteLine($"The Bill Fees = {Fees}");
                            }
                            else if (unCon > 450)
                            {
                                if (unCon > 600)
                                {
                                    Fees = ((unCon * 2.5) * .10) + (unCon * 2.5);
                                    Console.WriteLine($"The Bill Fees = {Fees}");
                                }
                                else
                                {
                                    Fees = unCon * 2.5;
                                    Console.WriteLine($"The Bill Fees = {Fees}");
                                }
                            }
                        }
                        catch (InvalidInputException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        break;

                    case 6:
                        break;

                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;
                }

                break;
            }
            break;

        case 3:
           while(true)
            {
                Console.WriteLine(" BANK SYSTEM");
                Console.WriteLine(" Main Menu");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Widthdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Please Enter your Choice");
                int bch = Convert.ToInt32(Console.ReadLine());

                double amount = 0;
                switch (bch)
                {
                    case 1:
                        Console.WriteLine("Enter The Amount:");
                        amount = Convert.ToDouble(Console.ReadLine());
                        if (amount > 0)
                            balance += amount;
                        else
                            Console.WriteLine("Invalid, Enter  positive value");
                        break;
                    case 2:
                        Console.WriteLine("Enter The Amount:");
                        amount = Convert.ToDouble(Console.ReadLine());
                        if (amount < balance)
                            balance -= amount;
                        else
                            Console.WriteLine("Invalid, More Than Balance");
                        break;
                    case 3:
                        Console.WriteLine($"Your Balance is: {balance}");
                        break;
                    case 4:
                        Console.WriteLine("DONE");
                        return;
                    default:
                        break;

                }
            }
         
        case 4:
            Console.WriteLine("Enter number of Students:");
            int sNum = Convert.ToInt32(Console.ReadLine());
            double[] grades = new double[sNum];
            int aboveAvg, belowAvg;
            for (int i = 0; i < sNum; i++)
            {
                Console.WriteLine($"Enter Grade for Student '{i}':");
                grades[i] = Convert.ToDouble(Console.ReadLine());

            }
            aboveAvg = grades.Count(g => g > grades.Average());
            belowAvg = grades.Count(g => g < grades.Average());
            Console.WriteLine($"Minmum Grade = {grades.Min()}");
            Console.WriteLine($"Maximum Grade = {grades.Max()}");
            Console.WriteLine($"Average Grade = {grades.Average()}");
            Console.WriteLine($"Grades Above Avg = {aboveAvg}");
            Console.WriteLine($"Grades Below Avg = {belowAvg}");

            break;
        case 5:
            Console.WriteLine("Enter The NO. of Terms for the Sequence");
            int terms = Convert.ToInt32(Console.ReadLine());
            PrintFibonacci(terms);
            break;

        case 6:
            Console.WriteLine("Exit the Program");
            return;

        default:
            break;


    }
}

public class InvalidInputException : Exception
{
    public InvalidInputException(string message) : base(message) { }
}

