﻿using System;
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

        //string[] theArgs = Environment.GetCommandLineArgs();
        //foreach(string arg in theArgs)
        //{

        //}

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


        //VariableDeclarations();
        Types();

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

    public static void VariableDeclarations()
    {
        int num = 12;
        int num2 = new int(); //// before initilizition is 0
        num2 = 34;

        //// or short version
        int num3 = new(); //// before initilizition is 0
        num3 = 45;

        bool aaa = default; //// false
    }

    public static void WorkWithConsole()
    {
        //var a = "aaa";
        //var b = "bbb";
        //Console.WriteLine("a is {0}, b is {1}", a, b);
    }

    public static void Types()
    {
        //var x = 12;
        //Console.WriteLine(x.GetType());

        //int x = 12;
        //Console.WriteLine(x.GetHashCode()); //// 12

        //string a = "Hello";
        //Console.WriteLine(a.GetHashCode());

        //Console.WriteLine(int.MinValue);
        //Console.WriteLine(int.MaxValue);
        //Console.WriteLine(double.Epsilon);
        //Console.WriteLine(double.PositiveInfinity);
        //Console.WriteLine(double.NegativeInfinity);

        //var x = 3L; //// setting type to long
        //var y = 3.34f; //// setting type to float

        //Console.WriteLine(bool.FalseString);
        //Console.WriteLine(bool.TrueString);


    }
}