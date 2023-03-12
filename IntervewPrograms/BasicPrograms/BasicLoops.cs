namespace BasicPrograms;
public class BasicLoops
{
    //Continue
    public static void Continue()
    {
        for (int i = 0; i < 7; i++)
        {
            if (i == 4)
            {
                continue;
            }
            Console.WriteLine("Print Value in Continue {0}", i);
        }
    }
    //Break
    public static void Break()
    {
        for (int i = 0; i < 7; i++)
        {
            if (i == 4)
            {
                break;
            }
            Console.WriteLine("Print Value in break {0}", i);
        }
    }

    //While
    public static void While()
    {
        int i = 0;
        while (i < 7)
        {
            Console.WriteLine("Print Value in while {0}", i);
            i++;
        }
    }
}
