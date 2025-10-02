using System.Diagnostics.CodeAnalysis;

public class Program
{
    public static int Add(int samNumber1, int brandonNumber1)
    {
        return samNumber1 + brandonNumber1;
    }
    public static void Main(string[] args)
    {
        int samFavoriteNumber;
        int brandonFavoriteNumber;
        int answer = 0;

        //intialize
        samFavoriteNumber = 42;
        brandonFavoriteNumber = 13;
        answer = Add(42, 13);

        public int Subtract(int a, int b)
        {
            return (b-a);
        }
        //start of our actual program
        Console.WriteLine("Sam's favorite number is " + samFavoriteNumber);
        Console.WriteLine("Brandon's favorite number is " + brandonFavoriteNumber);
        Console.WriteLine("When we add our favorite numbers together we get: " + answer);

}
}
