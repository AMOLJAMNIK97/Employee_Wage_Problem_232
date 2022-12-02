// See https://aka.ms/new-console-template for more information

using System.Threading.Tasks.Sources;

class Program
{
    public const int fullTime = 1;
    public const int PartTime = 2;
    public const int EmpRatePerHour = 20;
     
    static void Main(string[] args)
    {
        int empHrs = 0;
        int empWage = 0;
        Random randobj = new Random();
        int checkPresent = randobj.Next(0, 3);
        Console.WriteLine("Random number=" + checkPresent);
        switch (checkPresent)
        {
            case PartTime:
                empHrs = 4;
                break;
            case fullTime:
                empHrs = 8;
                break;
            default:
                empHrs = 0;
                break;
        }
        empWage = empHrs * EmpRatePerHour;
        Console.WriteLine("Emp Wage :" + empWage);
    }
}