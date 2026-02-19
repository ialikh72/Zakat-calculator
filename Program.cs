using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Are you Muslim(Y/N)");
        string religion = Console.ReadLine();
        Console.WriteLine("Enter your Current Balance:");
        double balance = Convert.ToDouble(Console.ReadLine());
        if(religion == "N")
            Console.WriteLine("Zakat is not applicable to you.....");
        else
        {
            if(balance >= 500000)
            {
                double zakat = balance * 0.025;
                Console.WriteLine("Your Zakat amount is: " + zakat);
            }
            else
                Console.WriteLine("Zakat is not applicable to you due to low balance....");
        }
    }
}
