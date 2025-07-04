namespace First_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("25$ per small carpet ");
            System.Console.WriteLine("35$ per large carpet");
            int Numberofsmallcarpets = Convert.ToInt32(Console.ReadLine());
            Numberofsmallcarpets = Numberofsmallcarpets * 25;
            System.Console.WriteLine($"Price per small carpet {Numberofsmallcarpets}");
            int Numberoflargecarpets = Convert.ToInt32(Console.ReadLine());
            Numberoflargecarpets = Numberoflargecarpets * 35;
            System.Console.WriteLine($"Price per large carpet {Numberoflargecarpets}");
            int cost = Numberofsmallcarpets + Numberoflargecarpets;
            System.Console.WriteLine($"cost {cost}\n");
            double taxes;
            taxes = 6.6;
            double total; 
            total = cost + taxes;
            System.Console.WriteLine(total);
            


           
            
           
        }
    }
}
