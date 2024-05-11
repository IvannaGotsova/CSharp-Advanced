namespace CSharp_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            string firstName = person.firstName = "Test";
            string lastName = person.lastName = "Test";

            int age = person.Age = 1;

            Console.WriteLine($"Full Name: {firstName} {lastName}, Age: {age}, Number: {person.number}");

            
        }
    }
}
