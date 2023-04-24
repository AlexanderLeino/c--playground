using System;
namespace ConsoleApp1 
{
    public class Program
    {

        //------ FUNCTIONS -------

        // ------ END OF FUNCTIONS ------

        static void PrintArray(int[] intArray, string mess) 
        {
            foreach(int k in intArray){
                Console.WriteLine("{0} : {1}", mess , k);
            }
        }

        //Void means that it will not return anything after executing!
        static void Main(string[] args) 
        {
           int[] favNums = new int[3];
           favNums[0] = 23;
           Console.WriteLine("Current Array {0}", favNums);
           Console.WriteLine("favNum 0 : {0}", favNums[0]);
           string[] customers = {"Bob", "Sally", "Sue"};
           var employees = new[] {"Mike", "Paul", "Rick"};
           object[] randomArray = {"Paul", 45, 1.234};
           Console.WriteLine("randomArray 0: {0}", randomArray[0].GetType());
           Console.WriteLine("Array Size: {0}", randomArray.Length);
           for(int j = 0; j < randomArray.Length; j++)
           {
                Console.WriteLine("Array : {0} : Value : {1}", favNums[j], j);
           }

           Console.WriteLine("-----------------------");

           string[,] custNames = new string[2,2] {{"Bob", "Smith"}, {
            "Sally", "Smith"
           }};
           Console.WriteLine("MD Value : {0}", custNames.GetValue(1,0));

           for(int a = 0; a < custNames.GetLength(0); a++){
            for (int b = 0; b < custNames.GetLength(0); b++) {
                Console.WriteLine("{0}", custNames[a, b]);
            }
           }

           int[] randomNumbers = {1,4,9,2};
            PrintArray(randomNumbers, "ForEach");

            Console.WriteLine("---------------");
            Array.Sort(randomNumbers);
            Array.Reverse(randomNumbers);
            Console.WriteLine("1 at index : {0}", Array.IndexOf(randomNumbers, 1));
            randomNumbers.SetValue(0, 1);
            int[] srcArray = {1, 2, 3};
            int[] destArray = new int[2];
            int startInd = 0;
            int length = 2;
            Array.Copy(srcArray, startInd, destArray, 0, length);
            PrintArray(destArray, "Copy");
            Array anotherArray = Array.CreateInstance(typeof(int), 10);
            srcArray.CopyTo(anotherArray, 5);
            foreach(int m in anotherArray){
                Console.WriteLine("CopyTo : {0}", m);
            }

        }

        private static bool GT10(int obj)
        {
            throw new NotImplementedException();
        }
    }
}