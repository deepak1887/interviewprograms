namespace ConstructorInterview.Constructor
{
    public class Child : Parent
    {
        #region constructor
        public Child(string str): base(str)
        {
            Console.WriteLine("childs's default constructor");
        }
        //private Child()
        //{
        //    Console.WriteLine("child's private constructor");
        //}
        static Child()
        {
            Console.WriteLine("child's static constructor");
        }
        #endregion
        public new void Sum()
        {
            Console.WriteLine("child's sum");
        }
        public override void VirtualMethod()
        {
            Console.WriteLine("child's VirtualMethod");
        }

        public new void ExtraMethod()
        {
            Console.WriteLine("child's ExtraMethod");
        }
    }
}
