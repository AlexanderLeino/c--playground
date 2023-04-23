using System;
namespace ConsoleApp1 
{
    public class Program
    {
        //Void means that it will not return anything after executing!
        static void Main(string[] args) 
        {
            string randString = "This is a string"; 
            Console.WriteLine("String Length : {0}", randString.Length);
            Console.WriteLine("String Contains is : {0}", randString.Contains("is"));
            Console.WriteLine("Index of is : {0}", randString.IndexOf("is"));
            Console.WriteLine("Remove : {0}", randString.Remove(10, 6));
            Console.WriteLine("Insert String: {0}", randString.Insert(10, "Short "));
            Console.WriteLine("Replace String : {0}", randString.Replace("string", "sentence"));

            Console.WriteLine("---------------------------------");
            Console.WriteLine("A = a : {0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Pad Left : {0}", randString.PadLeft(20, '.'));
            Console.WriteLine("Pad Right : {0}", randString.PadRight(20, '.'));
            Console.WriteLine("Trim Left : {0}", randString.Trim());
            Console.WriteLine("Uppercase : {0}", randString.ToUpper());
            Console.WriteLine("Lowercase: {0}", randString.ToLower());
            string newString = String.Format("{0} saw a {1} {2} in the {3}", "Paul", "rabbit", "eating", "Corn");
            Console.Write(newString + "\n");
            Console.WriteLine(@"Exactly What I Typed\n");
        
        }
    }
}