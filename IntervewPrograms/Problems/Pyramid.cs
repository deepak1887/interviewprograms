namespace Problems;
public class Pyramid
{
    public static void StarPyradmid()
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
