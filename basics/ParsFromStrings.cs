using System;

namespace basics
{
    public class ParsFromStrings
    {
        public ParsFromStrings()
        {
            Console.WriteLine(bool.Parse("true"));
            Console.WriteLine(bool.Parse("True"));
            Console.WriteLine(bool.Parse("false"));
            // Console.WriteLine(bool.Parse("sdsds")); // will throw System.FormatException

            Console.WriteLine(double.Parse("45.87"));
            Console.WriteLine(int.Parse("78"));

            Console.WriteLine(char.Parse("W"));
        }

        public void UsingTryParse()
        {
            // if (int.TryParse("45.31", out int res))
            // {
            //     Console.WriteLine("It's okey", res);
            // }
            // else
            // {
            //     Console.WriteLine("oops");
            // }

            try
            {
                Console.WriteLine(int.Parse("int"));
            }
            catch (Exception e)
            {
                Console.WriteLine("exception", e);
                throw;
            }
            finally
            {
                Console.WriteLine("finaly");
            }
        }
    }
}