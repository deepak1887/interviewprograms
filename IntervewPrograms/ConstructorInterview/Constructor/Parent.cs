namespace ConstructorInterview.Constructor
{
    public class Parent
    {
        //public Parent()
        //{
        //    Console.WriteLine("parent's public constructor");
        //}
        //private Parent()
        //{
        //    Console.WriteLine("parent's private constructor");
        //}
        //public Parent( string value)
        //{
        //    Console.WriteLine("parent's parameterised constructor with value "+ value);
        //}
        //static Parent()
        //{
        //    Console.WriteLine("parent's static constructor");
        //}
        public void Sum()
        {
            Console.WriteLine("parent's sum");
        }
        protected void ProtectedSum()
        {
            Console.WriteLine("parent's protected");
        }
        public virtual void VirtualMethod()
        {
            Console.WriteLine("parent's VirtualMethod");
        }
        public void ExtraMethod()
        {
            Console.WriteLine("parent's ExtraMethod");
        }
    }
}
