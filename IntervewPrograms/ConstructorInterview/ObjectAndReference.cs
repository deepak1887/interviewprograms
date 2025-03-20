namespace ConstructorInterview
{
    public class Sample
    {
        public string Str { get; set; } = string.Empty;
        public override string ToString()
        {
            return Str;
        }
    }
    public class ObjectAndReference
    {
        private static Sample samp = new Sample()
        {
            Str = "Sunny",
        };

        static int a = 10;
        static string str = "sunny";

        private static void ChangeInterger(int x)
        {
            x = 200;
            Console.WriteLine(x);
        }

        private static void ChangeString(string x)
        {
            x = "bill gates";
            Console.WriteLine(x);
        }

        private static void ChangeObjectString(Sample s)
        {
            s.Str = "bill gates";
            Console.WriteLine(s.Str);
        }
        public void Run()
        {
            Print();
            ChangeInterger(a);
            ChangeString(str);
            Console.WriteLine(a);
            Console.WriteLine(str);
            Console.WriteLine("Changing Non premitive data type");
            ChangeObjectString(samp);
            Console.WriteLine(samp.ToString());
            Console.WriteLine(samp.Str);
        }

        private static void Print()
        {
            Console.WriteLine(a);
            Console.WriteLine(str);
            Console.WriteLine("Non premitive data type");
            Console.WriteLine(samp.ToString());
            Console.WriteLine(samp.Str);
        }
    }
}
