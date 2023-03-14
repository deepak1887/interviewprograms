namespace Problems;
public class Pyramid
{
    public static void StraightPyradmid()
    {
        Console.WriteLine("Enter the number of lines: \n");
        int rows = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < rows; i++)
        {
            //spaces
            for (int j = 0; j < rows - i; j++)
            {
                Console.Write(" ");
            }

            //stars
            for (int m = 0; m <= i; m++)
            {
                Console.Write("* ");
            }
            Console.Write("\n");
        }
        Console.ReadKey();
    }

    public static void LeftPyradmid()
    {
        Console.WriteLine("Enter the number of lines: \n");
        int rows = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < rows; i++)
        {
            //stars
            for (int m = 0; m <= i; m++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
        Console.ReadKey();
    }

    public static void RightPyradmid()
    {
        Console.WriteLine("Enter the number of lines: \n");
        int rows = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < rows; i++)
        {

            //spaces
            for (int j = 0; j < rows - i; j++)
            {
                Console.Write(" ");
            }
            //stars
            for (int m = 0; m <= i; m++)
            {
                Console.Write("*");
            }

            Console.Write("\n");
        }
        Console.ReadKey();
    }

    public static void InvertedPyradmid()
    {
        Console.WriteLine("Enter the number of lines: \n");
        int rows = Convert.ToInt32(Console.ReadLine());
        for (int i = rows; i > 0; i--)
        {
            //spaces
            for (int j = 0; j < rows - i; j++)
            {
                Console.Write(" ");
            }

            //stars
            for (int m = 0; m < i; m++)
            {
                Console.Write("* ");
            }
            Console.Write("\n");
        }
        Console.ReadKey();
    }
}

public class PyramidDemo
{
    public static void Run()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welecome to pyramid problems.\nSelect options from below");
            Console.WriteLine("1. Print straight Pyramid");
            Console.WriteLine("2. Print Left Pyramid");
            Console.WriteLine("3. Print Right Pyramid");
            Console.WriteLine("4. Print Inverted Pyramid");
            Console.WriteLine("5. Exit");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Pyramid.StraightPyradmid();
                    break;
                case 2:
                    Pyramid.LeftPyradmid();
                    break;
                case 3:
                    Pyramid.RightPyradmid();
                    break;
                case 4:
                    Pyramid.InvertedPyradmid();
                    break;
                case 5:
                default:
                    break;
            }
            if(i == 5)
            {
                break;
            }
        }
    }
}
