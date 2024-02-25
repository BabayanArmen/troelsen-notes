using System;
using basics;

internal class Program
{
    private static void Main(string[] args)
    {

        //for(int i = 0; i< args.Length; i++)
        //{
        //    Console.WriteLine("Arg: {0}", args[i]);
        //}
        //foreach(string arg in args)
        //{
        //    Console.WriteLine(arg);
        //}
        string[] theArgs = Environment.GetCommandLineArgs();
        foreach(string arg in theArgs)
        {

        }

        //var value = System.Console.ReadLine();
        //System.Console.WriteLine("This is my first code in C% " + value);

        // NumberTypesMembers ntm = new NumberTypesMembers();
        // ntm.GetNumberTypesMembers();\

        // Chars chars = new Chars();
        // chars.SomeCharMethods();

        // ParsFromStrings parsFromStrings = new ParsFromStrings();
        // parsFromStrings.UsingTryParse();

        //DateTimeAndTimeSpan dtObject = new DateTimeAndTimeSpan();

        //Person p = new Person();
        //p.Name = "John";
        //p.Age = 40;
        //p.Print();

    }

    //struct Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }

    //    public void Print()
    //    {
    //        Console.WriteLine($"Hello my name is {Name}, I am {Age} years old");
    //    }
    //}
}