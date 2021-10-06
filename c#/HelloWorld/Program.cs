using System;
//This is a comment
/*dotnet run
Comment 
MultiLines
use PascalCae naming convention AllWordsStartWithCapitals
use camelCase for naming fields firstWordIsCapitialized
*/
namespace HelloWorld
{
    class Program
    {
        /*
           Main method is the first method that will be called run Compiler looks for main
           static means I don't have to instanciate an class to use a static method
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program test=new Program();
            test.Example();
            /*If method is not static then the class has to be instanciated*/
            Program.Example2();
            System.Console.WriteLine(Program.ExampleInt());
            House house=new House();
        
            house.Owner="McCool";
            System.Console.WriteLine( house.ToString()+"  "+house.Owner);
        
            //Collection collection =new Collection("Hello");
            //List<string> strings = new List<string>();
            //strings.Add("name2");
        }
        public void Example(){

        }
        public static void Example2(){
            System.Console.WriteLine("Your number is: ");

        }
         public static int ExampleInt(){
             return 10;

        }
    }
}
