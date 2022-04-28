public class Program
{

    public static void Main(string[] args)
    {
        bool isEqual;
        isEqual = Program.IsTheSame(5, 3);
        Console.WriteLine();
        Console.WriteLine(isEqual);

        double minus;
        minus = Program.Subtract(5.5, 3.1);
        Console.WriteLine();
        Console.WriteLine(minus);

        string building;
        building = Program.FindBuildingType(38);
        Console.WriteLine();
        Console.WriteLine(building);

        Console.ReadLine();
    }
    public static bool IsTheSame(int num1, int num2)
    {

        if (num1 == num2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }


    public static string FindBuildingType(int num1)
    {
        string house = "This is a house!";
        string office = "This is an office building!";
        string skyScraper = "This is a skyscraper!";
        string sSkyScraper = "This is a SUPER skyscraper!";

        if (num1 <= 3)
        {
            return house;
        }
        else if (num1 >= 4 && num1 <= 10)
        {
            return office;
        }
        else if (num1 >= 11 && num1 <= 49)
        {
            return skyScraper;
        }
        else if (num1 is >= 50)
        {
            return sSkyScraper;
        }
        else
        {
            return null;
        }
    }

}
