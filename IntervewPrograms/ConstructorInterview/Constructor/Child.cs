namespace ConstructorInterview.Constructor
{
    public class Child : Parent
    {
        //public Child() 
        //{
        //    Console.WriteLine("childs's default constructor");
        //}
        //public Child(): base("deepak")
        //{
        //    Console.WriteLine("childs's public constructor");
        //}
        //private Child()
        //{
        //    Console.WriteLine("parent's private constructor");
        //}
        //static Child()
        //{
        //    Console.WriteLine("child's static constructor");
        //}
        public new void Sum()
        {
            Console.WriteLine("child's sum");
        }
        public override void VirtualMethod()
        {
            Console.WriteLine("child's VirtualMethod");
        }

        new public void ExtraMethod()
        {
            Console.WriteLine("child's ExtraMethod");
        }
    }
}
