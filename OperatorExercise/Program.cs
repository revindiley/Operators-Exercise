using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var answer = methods.AreaOfCircle( radius );
            Console.WriteLine(answer);
        }
       
        

    }

}

        
