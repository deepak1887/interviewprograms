namespace ConstructorInterview.InterfacesTest
{
    public class BasicMaths : AbstractBasicMaths
    {
        int _a, _b;
        public BasicMaths(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public override void Multiply()
        {
            throw new NotImplementedException();
        }
        //public void IsPrimeNumber()
        //{
        //   Console.Write(_a % 2 == 0);
        //}
        //public void Multiply()
        //{
        //    Console.Write(_a * _b);
        //}
        //public void Subtract()
        //{
        //    Console.Write(_a - _b);
        //}
        //public void Sum()
        //{
        //    Console.Write(_a + _b);
        //}
    }
}
