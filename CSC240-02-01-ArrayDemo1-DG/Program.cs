using static System.Console;
class ArrayDemo1
{
    static void Main()
    {
        double[] payRate = { 12.00, 16.34, 18.11, 21.44 };
        for (int x = 0; x < payRate.Length; ++x)
            WriteLine("Pay rate {0} is {1}",
                x, payRate[x].ToString("C"));
    }
}