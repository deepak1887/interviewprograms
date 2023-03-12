namespace ConstructorInterview.Pyramid
{
    public static class PyramidProblem
    {
        public static void LeftReversePyramid(int height)
        {
            while (height > 0)
            {
                for (int i = height; i > 0; i--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                height--;
            }
            Console.ReadLine();
        }
        public static void RightReversePyramid(int height)
        {
            int spacing = 0;
            while (height > 0)
            {
                for (int j = 0; j < spacing; j++)
                {
                    Console.Write(" ");
                }
                for (int i = height; i > 0; i--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                height--;
                spacing++;
            }
            Console.ReadLine();
        }

        public static void LeftPyramid(int height)
        {
            int top = 0;
            while (top < height)
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
                top++;
            }
            Console.ReadLine();
        }
        public static void RightPyramid(int height)
        {
            int top = 0;
            while (top < height)
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
                top++;
            }
            Console.ReadLine();
        }

        public static void StraightPyramid(int height)
        {
            for (int level = 1; level <= height; level++)
            {
                var str = string.Join(" ", Enumerable.Repeat("*", level));
                Console.WriteLine(str.PadLeft(height - level + str.Length));
            }

        }
        public static void ReversePyramid(int height)
        {
            for (int level = height; level >= 1; level--)
            {
                var str = string.Join(" ", Enumerable.Repeat("*", level));
                Console.WriteLine(str.PadLeft(height - level + str.Length));
            }

        }
    }
}
