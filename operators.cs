using system;
using math;
namespace OperatorExercise
{
    public class Program
    {
     static void Main(string[] args)
        {
            var a = 27;
            var b = 4;
            var quot = a / b;
            var rem = a % b;
            double rad = 77;
            double area;
            Console.WriteLine(a + "/ " + b + "= " + quot);
            Console.WriteLine(a + "% " + b + "= " + rem);
            area = areaofacircle(rad);


        }

        public static double areaofacircle(double radios)
        {
            return Math.PI * Math.Pow(radios, 2);
        }
    }
}
