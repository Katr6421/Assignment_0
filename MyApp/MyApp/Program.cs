
public class Program
{
    public static void Main(string[] args)
    {
        int userinput = 0;
        Console.WriteLine("Enter year");


        try
        {
            userinput = Convert.ToInt32(Console.ReadLine());
            IsLeapYear(userinput);
        }


        catch (System.FormatException e)
        {
            Console.WriteLine("Du skal skrive et tal, tak :)");
        }

    }


    public static bool IsLeapYear(int year)
    {
        if (year < 1582)
        {
            Console.WriteLine("Det skal være et år efter 1582");
            return false;
        }

        if ((year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)))
        {
            Console.WriteLine("yay!!<333");
            return true;
        }

        else
        {
            Console.WriteLine("næ du");
            return false;
        }
    }
}








