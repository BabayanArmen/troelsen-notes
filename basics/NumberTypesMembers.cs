using System;

namespace basics
{
    public class NumberTypesMembers
    {
        public void GetNumberTypesMembers()
        {
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.PositiveInfinity);
            Console.WriteLine(double.NegativeInfinity);
            Console.WriteLine(double.Epsilon);
            
            var someFloat = 55.25F;
            Console.WriteLine(someFloat);

            var someLong = 125L;
            Console.WriteLine(someLong);
        }
    }
}