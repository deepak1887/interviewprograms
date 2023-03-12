namespace ConstructorInterview
{
    public class Sample
    {
        public string Str { get; set; }
        public void sampleMethod()
        {
        }
    }
    public class ObjectAndReference
    {
        Sample samp = new Sample()
        {
            Str = "Sunny",
        };

        int a = 10;
        string str = "sunny";

        void ChangeInterger(int x)
        {
            x = 200;
            Console.WriteLine(x);
        }
        void ChangeString(string x)
        {
            x = "bill gates";
            Console.WriteLine(x);
        }
        public void Run()
        {
            Print();
            ChangeInterger(a);
            ChangeString(str);
            Console.WriteLine(a);
            Console.WriteLine(str);
        }

        void Print()
        {
            Console.WriteLine(a);
            Console.WriteLine(str);
        }
    }
}
