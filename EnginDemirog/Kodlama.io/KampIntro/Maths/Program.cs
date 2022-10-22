using System;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            FourOperations fourOperations=new FourOperations();
            fourOperations.Collect(5,6);
            fourOperations.Collect(7,8);
        }
    }
}