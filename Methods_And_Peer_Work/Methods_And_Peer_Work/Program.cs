using System.Diagnostics.CodeAnalysis;

public class Program
{
    /*Samuel LaMere, Brandon Kass
     IGME 201.01 - Interac. Des. & Alg. Prob. Sol. III
    DUE: 10/12/2025
    */
    /// <summary>
    /// Adds 2 given integer parameters
    /// </summary>
    /// <param name="samNumber1"></param>
    /// <param name="brandonNumber1"></param>
    /// <returns> samNumber1 + brandonNumber </returns>
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
        answer = Add(samFavoriteNumber,brandonFavoriteNumber);

        int Subtract(int a, int b)
        {
            return (a-b);
        }
        //start of our actual program
        Console.WriteLine("Sam's favorite number is " + samFavoriteNumber);
        Console.WriteLine("Brandon's favorite number is " + brandonFavoriteNumber);
        Console.WriteLine("When we add our favorite numbers together we get: " + answer);
        answer = Subtract(samFavoriteNumber, brandonFavoriteNumber);
        Console.WriteLine("When we subtract our favorite numbers from each other we get: " + answer);

}
}
