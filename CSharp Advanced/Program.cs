using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace CSharp_Advanced
{
    internal class Program
    {
        //static void PrintFirstThread()
        //{
        //    Thread.Sleep(500);
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"Thread 1: {i}");
        //        Thread.Sleep(400); 
        //    }
        //}

        //static void PrintSecondThread()
        //{
        //    Thread.Sleep(500);
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine($"Thread 2: {i}");
        //        Thread.Sleep(800); 
        //    }
        //}
        //public delegate void MyDelegateExample(string delegateStringExample);

        //[Flags]
        //enum Colors 
        //{
        //    None = 0,
        //    Black = 1,
        //    Red = 2,
        //    Green = 4,
        //    Blue = 8,
        //    White = 16,
        //    Orange = 32
        //};

        static void Main(string[] args)
        {
            //Data Boxing
            int number = 4;         
            object boxedNumber = number;


            ////Dynamic Var
            //dynamic textDynamic = "Hello, world DYNAMIC!";
            //var textVar = "Hello, world VAR!";

            //Console.WriteLine(textDynamic);
            //Console.WriteLine(textVar);

            ////Dependency Injection
            //IDependencyInjection dependencyInjection = new DependencyInjectionClass();
            //dependencyInjection.DependencyInjection("Dependency Injection");

            ////Loose Coupling
            //ILooseCoupling looseCoupling = new LooseCouplingClass(); 
            //looseCoupling.LooseCoupling("Loose Coupling");


            ////Ref, Out, In 

            //int MultiplyNumber(int number)
            //{
            //    return number *= 2;
            //}
            //int numberToMultiply = 2;
            //numberToMultiply = MultiplyNumber(numberToMultiply);
            //Console.WriteLine(numberToMultiply);

            //void MultiplyNumberRef(ref int number)
            //{
            //    number *= 2;
            //}
            //int numberToMultiplyRef = 2;
            //MultiplyNumberRef(ref numberToMultiplyRef);
            //Console.WriteLine(numberToMultiplyRef);

            //void MultiplyNumberNoRef(int number)
            //{
            //    number *= 2;
            //}
            //int numberToMultiplyNoRef = 2;
            //MultiplyNumberNoRef(numberToMultiplyNoRef);
            //Console.WriteLine(numberToMultiplyNoRef);

            //void ShowNumber(in int number)
            //{
            //    Console.WriteLine(number);
            //}
            //ShowNumber(2);

            //void GiveValue(out int number)
            //{
            //    number = 2;
            //}
            //int number;
            //GiveValue(out number);
            //Console.WriteLine(number);

            ////Yield break
            //foreach (int number in GenerateNumbersTwo(100))
            //{
            //    Console.WriteLine(number);
            //}

            //static IEnumerable<int> GenerateNumbersTwo(int numberMoreThanFive)
            //{
            //    if (numberMoreThanFive <= 5)
            //    {
            //        Console.WriteLine("Number must be greater than 5");
            //        yield return 0;
            //    }
            //    yield return 1;
            //    yield return 2;
            //    yield return 3;
            //    yield return 4;
            //    yield return 5;

            //    for (int i = 6; i <= numberMoreThanFive; i++)
            //    {
            //        if (i == 50)
            //        {
            //            Console.WriteLine("You reached 50");
            //            yield break;
            //        }
            //        yield return i;
            //    }
            //}


            ////Yield 
            //foreach (int number in GenerateNumbers(100))
            //{
            //    Console.WriteLine(number);
            //}

            //static IEnumerable<int> GenerateNumbers(int numberMoreThanFive)
            //{
            //    if (numberMoreThanFive <= 5)
            //    {
            //        Console.WriteLine("Number must be greater than 5");
            //        yield return 0;
            //    }
            //    yield return 1;
            //    yield return 2;
            //    yield return 3;
            //    yield return 4;
            //    yield return 5;

            //    for (int i = 6; i <= numberMoreThanFive; i++)
            //    {
            //        yield return i;
            //    }
            //}


            ////Events
            //while (true)
            //{
            //    Console.WriteLine("Press any key.");
            //    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            //    if (keyInfo.Key == ConsoleKey.Q)
            //    {
            //        Console.WriteLine($"Pressed: {keyInfo.Key}");
            //        Console.WriteLine("THE END");
            //        break;
            //    }
            //    else if (keyInfo.Key == ConsoleKey.Z)
            //    {
            //        Console.WriteLine("FIRST");
            //    }
            //    else if (keyInfo.Key == ConsoleKey.X)
            //    {
            //        Console.WriteLine("SECOND");
            //    }
            //    else if (keyInfo.Key == ConsoleKey.Y)
            //    {
            //        Console.WriteLine("THIRD");
            //    }
            //    else if (keyInfo.Key == ConsoleKey.U)
            //    {
            //        Console.WriteLine("FOURTH");
            //    }
            //    Console.WriteLine($"Pressed: {keyInfo.Key}");

            //}


            ////Predicate, Func, Action 

            //Predicate<int> isFour = x => x == 4;
            //Console.WriteLine(isFour(4));

            //Func<int, int, int> printSum = (x, y) => x + y;
            //Console.WriteLine(printSum(5, 3));

            //Action<string> printHello = x => Console.WriteLine($"Hello {x}");
            //printHello("World");


            ////Multithreading
            //Thread threadOne = new Thread(PrintFirstThread);
            //threadOne.Start();
            //Thread threadTwo = new Thread(PrintSecondThread);
            //threadTwo.Start();
            //Console.WriteLine("Main Thread");

            //Async
            //var result = TaskAsyncClass.SecondTask().GetAwaiter().GetResult();
            //Console.WriteLine(result);


            ////LINQ
            //int[] numbers = [1, 3, 4, 5, 6, 8, 9, 11, 14, 16, 18, 20, 26, 28, 34, 39, 41, 44, 47, 55, 66, 71, 74, 79, 83, 85, 87, 92, 98];
            //List<int> evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
            //evenNumbers.ForEach(x => Console.WriteLine(x));
            //List<int> evenNumbersMultiply = evenNumbers.Select(x => x * 2).ToList();
            //evenNumbersMultiply.ForEach(x => Console.WriteLine(x));


            ////Tuples C#
            //var example = ("Example", 1, true, 10.00);
            //Console.WriteLine(example.Item1); 
            //Console.WriteLine(example.Item2); 
            //Console.WriteLine(example.Item3);
            //Console.WriteLine(example.Item4);

            //(string name, int number, bool isBool, double numberDouble) example2 = (name: "Example2", number: 11, isBool: true, numberDouble: 11.00);
            //Console.WriteLine(example2.name);
            //Console.WriteLine(example2.number);
            //Console.WriteLine(example2.isBool);
            //Console.WriteLine(example2.numberDouble);

            //(int minNum, int maxNum) FindMinMax(List<int> numbers)
            //{
            //    return (numbers.Min(), numbers.Max());
            //}
            //Console.WriteLine(FindMinMax(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}));

            ////Аnonymous type
            //var Example = new { Name = "example", Number = 1 };
            //Console.WriteLine($"Name: {Example.Name}, Number: {Example.Number}");


            ////Class Indexer 

            //ClassIndexer classIndexer = new ClassIndexer();
            //for (int i = 0; i < classIndexer.Length; i++)
            //{
            //    classIndexer[i] = i;
            //    Console.WriteLine(i);
            //}

            ////Dynamic

            //dynamic example = "Example";
            //Console.WriteLine(example);
            //example = 2;
            //Console.WriteLine(example);
            //example = true;
            //Console.WriteLine(example);
            //Console.WriteLine(example.ToString());
            //Console.WriteLine(example.ToUpper());


            ////Ref, Out, In 

            //int MultiplyNumber(int number)
            //{
            //    return number *= 2;               
            //}
            //int numberToMultiply = 2;
            //numberToMultiply = MultiplyNumber(numberToMultiply);
            //Console.WriteLine(numberToMultiply);

            //void MultiplyNumberRef(ref int number)
            //{
            //    number *= 2;
            //}
            //int numberToMultiplyRef = 2;
            //MultiplyNumberRef(ref numberToMultiplyRef);
            //Console.WriteLine(numberToMultiplyRef);

            //void MultiplyNumberNoRef(int number)
            //{
            //    number *= 2;
            //}
            //int numberToMultiplyNoRef = 2;
            //MultiplyNumberNoRef(numberToMultiplyNoRef);
            //Console.WriteLine(numberToMultiplyNoRef);

            //void ShowNumber(in int number)
            //{
            //    Console.WriteLine(number);
            //}
            //ShowNumber(2);

            //void GiveValue(out int number)
            //{
            //    number = 2; 
            //}
            //int number;
            //GiveValue(out number);
            //Console.WriteLine(number);

            ////Enum Flags

            //Colors multicolor = Colors.Black | Colors.Green | Colors.White;
            //Console.WriteLine(multicolor);

            ////NULL
            //int? number = null;
            //string? text = null;

            //string example = null;
            //string exampleCheck = example ?? "Example";
            //Console.WriteLine(exampleCheck);
            //example = "Not NULL";
            //exampleCheck = example ?? "Example";
            //Console.WriteLine(exampleCheck);


            ////Class, Struct, Record 

            //ClassStructRecord classStructRecord = new ClassStructRecord();
            //Console.WriteLine(classStructRecord.example);
            //Console.WriteLine(classStructRecord.number);
            //classStructRecord.number = 3;
            //Console.WriteLine(classStructRecord.number);

            //Struct structRecord = new Struct();
            //Console.WriteLine(structRecord.example);
            //Console.WriteLine(structRecord.number);
            //structRecord.number = 4;
            //Console.WriteLine(structRecord.number);

            //Record record = new Record();
            //Console.WriteLine(record.example);
            //Console.WriteLine(record.number);
            //record.number = 5; 
            //Console.WriteLine(record.number);


            //default

            //string exampleString = default;
            //int exampleInt= default;
            //double exampleDouble = default;
            //decimal exampleDecimal = default;
            //float exampleFloat = default;

            //Console.WriteLine(exampleString);
            //Console.WriteLine(exampleInt);
            //Console.WriteLine(exampleDouble);
            //Console.WriteLine(exampleDecimal);
            //Console.WriteLine(exampleFloat);

            ////Static constructor
            //Person person = new Person();

            ////typeof, sizeof, nameof 

            //Person person = new Person();
            //Console.WriteLine(typeof(Person));
            //Console.WriteLine(nameof(person));
            //Console.WriteLine(sizeof(byte));

            ////Span

            //int[] numbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            //Span<int> spaNumbers = new Span<int>(numbers, 1, 9);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine("numbers - " + item);
            //}

            //foreach (var item in spaNumbers)
            //{
            //    Console.WriteLine("Span numbers - " + item);
            //}

            ////Method Extension

            //Console.WriteLine(ToStringExtensions.ToStringExtension());

            ////Reflection

            //ReflectionExample reflectionExample = new ReflectionExample();
            //reflectionExample.ReflectionExampleMethdod();

            //Type reflectionExampleType = typeof(ReflectionExample);
            //object reflectionExampleInstance = Activator.CreateInstance(reflectionExampleType);
            //MethodInfo reflectionExampleMethodInfo = reflectionExampleType.GetMethod("ReflectionExampleMethdod");
            //Console.WriteLine(reflectionExampleMethodInfo);
            //reflectionExampleMethodInfo.Invoke(reflectionExampleInstance, null);



            ////Extension methods

            //ClassToBeExtended classToBeExtended = new ClassToBeExtended();

            //classToBeExtended.AddOne(100);
            //classToBeExtended.AddTwo(100);
            //classToBeExtended.AddThree(100);
            //classToBeExtended.AddFour(100);
            //classToBeExtended.AddFive(100);
            //classToBeExtended.AddSix(100);
            //classToBeExtended.AddSeven(100);
            //classToBeExtended.AddEight(100);
            //classToBeExtended.AddNine(100);
            //classToBeExtended.Print();

            //// Reflection

            //Person personExample = new Person();

            //Type personExampleType = typeof(Person);

            //Console.WriteLine(personExampleType);

            //foreach (PropertyInfo property in personExampleType.GetProperties())
            //{
            //    Console.WriteLine(property.Name);
            //}

            //foreach (MethodInfo method in personExampleType.GetMethods())
            //{
            //    Console.WriteLine(method.Name);
            //}

            //Animal dogReflection = new Dog();
            //MethodInfo dogClassMethodInfo = typeof(Dog).GetMethod("AnimalSayFullHello");
            //dogClassMethodInfo.Invoke(dogReflection, new object[] { });

            //Person personReflection = new Person();
            //MethodInfo personClassMethodInfo = typeof(Person).GetMethod("StaticClassExample");
            //personClassMethodInfo.Invoke(personReflection, new object[] { });

            //// Reflection - basic

            //double doubleExample = 23.78;
            //System.Type typeExample = doubleExample.GetType();
            //System.Console.WriteLine(typeExample);

            ////Functional Programming

            //List<int> numbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            //static bool isEven(int x) => x % 2 == 0;
            //static bool isOdd(int x) => x % 2 == 1;

            //var evenNumbers = numbers.Where(isEven).ToList();
            //var oddNumbers = numbers.Where(isOdd).ToList();

            //numbers.ForEach(Console.Write);
            //Console.WriteLine();
            //evenNumbers.ForEach(Console.Write);
            //Console.WriteLine();
            //oddNumbers.ForEach(Console.Write);

            ////yield
            //foreach (var number in GetNumbers())
            //{
            //    Console.WriteLine(number);
            //}

            //Asynchronous programming

            //FirstProcess();
            //SecondProcess();
            //ThirdProcess();
            //FourthProcess();
            //FifthProcess();

            //Events
            //SeniorEmployee seniorEmployee = new SeniorEmployee ();
            //seniorEmployee.Salary = 1000;

            //seniorEmployee.OnSalaryIncreased += EventOnSalaryIncreaased;
            //seniorEmployee.OnSalaryDecreased += EventOnSalaryDecreaased;

            //seniorEmployee.Salary = 1500;
            //seniorEmployee.Salary = 500;
            //seniorEmployee.Salary = 300;
            //seniorEmployee.Salary = 500;
            //seniorEmployee.Salary = 300;
            //seniorEmployee.Salary = 500;

            //JuniorEmployee juniorEmployee = new JuniorEmployee();
            //juniorEmployee.Experience = 30;

            //juniorEmployee.OnExperienceIncreased += EventOnExperienceIncreased;
            //juniorEmployee.OnExperienceDecreased += EventOnExperienceDecreased;

            //juniorEmployee.Experience = 20;
            //juniorEmployee.Experience = 10;
            //juniorEmployee.Experience = 20;
            //juniorEmployee.Experience = 30;
            //juniorEmployee.Experience = 40;
            //juniorEmployee.Experience = 30;

            ////Delegates
            //MyDelegateExample delegateExample = FirstMethodExample;
            //delegateExample("First example");
            //delegateExample = SecondMethodExample;
            //delegateExample("Second example");
            //delegateExample = ThirdMethodExample;
            //delegateExample("Third example");
            //delegateExample = FourthMethodExample;
            //delegateExample("Fourth example");
            //delegateExample = FifthMethodExample;
            //delegateExample("Fifth example");

            //static void FirstMethodExample(string example)
            //{
            //    Console.WriteLine(example);
            //}
            //static void SecondMethodExample(string example)
            //{
            //    Console.WriteLine(example);
            //}
            //static void ThirdMethodExample(string example)
            //{
            //    Console.WriteLine(example);
            //}
            //static void FourthMethodExample(string example)
            //{
            //    Console.WriteLine(example);
            //}
            //static void FifthMethodExample(string example)
            //{
            //    Console.WriteLine(example);
            //}

            ////Generics
            //Employee<SeniorEmployee> seniorEmployee = new Employee<SeniorEmployee>();
            //seniorEmployee.GetFullName("Test", "Test");
            //seniorEmployee.GetFullInfo("Test", "Test", 50);
            //seniorEmployee.GetGreeting("Test", "Test");
            //seniorEmployee.GetBonus(10, 10000);
            //Employee<JuniorEmployee> juniorEmployee = new Employee<JuniorEmployee>();
            //juniorEmployee.GetFullName("Test", "Test");
            //juniorEmployee.GetFullInfo("Test", "Test", 30);
            //juniorEmployee.GetGreeting("Test", "Test");
            //juniorEmployee.GetBonus(5, 5000);

            ////Extension method 
            //ClassToBeExtended classToBeExtended = new ClassToBeExtended();
            //classToBeExtended.FourthMethod();
            //classToBeExtended.FifthMethod();
            //classToBeExtended.SixthMethod();

            ////static keyword 
            //Person person = new Person();
            //Console.WriteLine($"Person signature: {Person.signature}");
            //Person.StaticClassExample();

            //// Abstraction
            //Dog dog = new Dog();
            //dog.AnimalSayHello();
            //dog.AnimalSayFullHello();

            //// Encapsulation 
            //Person person = new Person();
            //string firstname = person.firstName = "test";
            //string lastname = person.lastName = "test";
            //int age = person.Age = 1;
            //Console.WriteLine($"full name: {firstname} {lastname}, age: {age}, number: {person.number}");

        }

        //private static IEnumerable<object> GetNumbers()
        //{
        //    for (int i = 1; i <= 20; i++)
        //    {
        //        yield return i;
        //    }
        //}

        //private static void FifthProcess()
        //{
        //    Console.WriteLine("Fifth Process begin");
        //    Console.WriteLine("Fifth Process stop");
        //}

        //private static async Task FourthProcess()
        //{
        //    await Task.Delay(1000);
        //    Console.WriteLine("Fourth Process begin");
        //    Console.WriteLine("Fourth Process stop");
        //}

        //private static async Task ThirdProcess()
        //{
        //    Console.WriteLine("Third Process begin");
        //    await Task.Delay(5000);
        //    Console.WriteLine("Third Process stop");
        //}

        //private static async Task SecondProcess()
        //{
        //    Console.WriteLine("Second Process begin");
        //    await Task.Delay(10000);
        //    Console.WriteLine("Second Process stop");
        //}

        //private static void  FirstProcess()
        //{
        //    Console.WriteLine("First Process begin");
        //    Console.WriteLine("First Process stop");
        //}

        //private static void EventOnExperienceDecreased(object? sender, int e)
        //{
        //    var juniorEmployee = sender as JuniorEmployee;
        //    Console.WriteLine("Experience increased");
        //}

        //private static void EventOnExperienceIncreased(object? sender, int e)
        //{
        //    var juniorEmployee = sender as JuniorEmployee;
        //    Console.WriteLine("Experience decreased");
        //}

        //private static void EventOnSalaryDecreaased(object? sender, decimal salary)
        //{
        //    var seniorEmployee = sender as SeniorEmployee;
        //    Console.WriteLine("Salary increased");
        //}

        //private static void EventOnSalaryIncreaased(object? sender, decimal salary)
        //{
        //    var seniorEmployee = sender as SeniorEmployee;
        //    Console.WriteLine("Salary decreased");
        //}

    }

    //public static class ToStringExtensions
    //{
    //    public static string ToStringExtension()
    //    {
    //        return "To String Extension Method";
    //    }
    //}
}
