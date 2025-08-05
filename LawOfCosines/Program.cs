using SimpleMathExamples;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace SimpleMathExamples
{
    public class Program
    {
        int[] numbers = new int[] { 1, 2, 3, 4, 5 };


        static void Main(string[] args)
        {
            // Pythagorean Theorem:
            PythagoreanTheorem pythagoreanTheorem = new PythagoreanTheorem();

            double a = 8;
            double b = 11;

            double a1 = 1;
            double b1 = 2;

            List<double> list = new List<double>();
            List<string> listOfStrings = new List<string>();


            list.Add(1);
            list.Add(2);

            list.Remove(1);

            int[] numbers = new int[] { 1, 2, 3, 4, 5 };



            pythagoreanTheorem.Solve(a, b);
            // Pythagorean Theorem complete

            // More examples:
            // Law of Cosines:
            LawOfCosines lawOfCosines = new LawOfCosines();

            double angleC = 37;

            lawOfCosines.Solve(a, b, angleC);
            // Law of Cosines complete


        }

        public static int DataStructureList()
        {
            // Size does change
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //numbers.Count();

            numbers.Add(11);

            return numbers.Sum();
        }

        public static int DataStructureArray()
        {
            // Size doesn't change
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            return numbers.Sum();
        }
    }
}
