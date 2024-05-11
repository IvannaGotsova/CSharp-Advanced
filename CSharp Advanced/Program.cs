namespace CSharp_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Abstraction
            Dog dog = new Dog();
            dog.AnimalSayHello();
            dog.AnimalSayFullHello();

            //// Encapsulation 
            //person person = new person();
            //string firstname = person.firstname = "test";
            //string lastname = person.lastname = "test";

            //int age = person.age = 1;

            //console.writeline($"full name: {firstname} {lastname}, age: {age}, number: {person.number}");


        }
    }
}
