namespace CSharp_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Extension method 
            ClassToBeExtended classToBeExtended = new ClassToBeExtended();
            classToBeExtended.FourthMethod();
            classToBeExtended.FifthMethod();
            classToBeExtended.SixthMethod();

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
    }
}
