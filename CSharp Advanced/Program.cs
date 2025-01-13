using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace CSharp_Advanced
{
    internal class Program
    {
        //public delegate void MyDelegateExample(string delegateStringExample);

        static void Main(string[] args)
        {
            
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

    }
