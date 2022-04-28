public class Program
{

    public static void Main()
    {
        bool isEqual;
        isEqual = Program.IsTheSame();
        Console.WriteLine();
        Console.WriteLine(isEqual);

        double minus;
        minus = Program.Subtract();
        Console.WriteLine();
        Console.WriteLine(minus);

        string building;
        building = Program.FindBuildingType();
        Console.WriteLine();
        Console.WriteLine(building);

        Console.ReadLine();
    }
    public static bool IsTheSame()
    {

        int num1 = 0;
        int num2 = 0;
        bool userAns = false;
        bool userBns = false;

        Console.WriteLine("Please enter an integer: ");
        string userNumX = Console.ReadLine();
        userAns = int.TryParse(userNumX, out num1);

        Console.WriteLine();
        Console.WriteLine("Please enter another integer: ");
        string userNumY = Console.ReadLine();
        userBns = int.TryParse(userNumY, out num2);

        if (num1 == num2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static double Subtract()
    {

        double num1 = 0;
        double num2 = 0;
        bool userAns = false;
        bool userBns = false;

        Console.WriteLine("Please enter any number: ");
        string userNumX = Console.ReadLine();
        userAns = double.TryParse(userNumX, out num1);

        Console.WriteLine();
        Console.WriteLine("Please enter another number: ");
        string userNumY = Console.ReadLine();
        userBns = double.TryParse(userNumY, out num2);

        double sum = num1 - num2;
        return sum;
    }


    public static string FindBuildingType()
    {
        int num1 = 0;
        bool userAns = false;
        string house = "This is a house!";
        string office = "This is an office building!";
        string skyScraper = "This is a skyscraper!";
        string sSkyScraper = "This is a SUPER skyscraper!";

        Console.WriteLine("Please enter an integer: ");
        string userNumX = Console.ReadLine();
        userAns = int.TryParse(userNumX, out num1);

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
