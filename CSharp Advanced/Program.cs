using System;
using System.Runtime.CompilerServices;

namespace CSharp_Advanced
{
    internal class Program
    {
        //public delegate void MyDelegateExample(string delegateStringExample);

        static void Main(string[] args)
        {
            //

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

    }
