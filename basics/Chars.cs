using System;

namespace basics
{
    public class Chars
    {
        public void SomeCharMethods()
        {
            Console.WriteLine(char.IsDigit('5'));
            Console.WriteLine(char.IsDigit('o'));
            Console.WriteLine(char.IsLetter('a'));
            Console.WriteLine(char.IsWhiteSpace(' '));
            Console.WriteLine(char.IsWhiteSpace("Hello World", 5));
            Console.WriteLine(char.IsPunctuation('!'));
        }
    }
}