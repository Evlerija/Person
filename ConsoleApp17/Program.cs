using System;

namespace ConsoleApp17
{
    public partial class Program : Person
    {
        static void Main(string[] args)
        {
            Person Alex = new Person("Alex", 24);
            Person Alexander = new Person();
            Console.WriteLine(Alex.Move(Alex.FullName));
            Console.WriteLine(Alex.Talk(Alex.FullName));
        }
        
        
    }
    public class Person
    {
        public string FullName; public sbyte Age;
        public Person(string fullname, sbyte age) 
        {
            FullName = fullname;
            Age = age;
        }
        public string Talk(string fullname)
        {
            string FullName = "Такой- то "  + fullname + " говорит.";
            return FullName;
        }
        public string Move(string fullname)
        {
            string FullName = "Такой- то "  + fullname + " говорит.";
            return FullName;
        }
        public Person()
        {
            return;
        }
    }
}
