namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount();

            Console.WriteLine($"Current Balance: ${myAccount.GetBalance()}");

            Console.WriteLine("How much would you like to deposit?");

            Console.Write("$");
            var userInput = double.Parse( Console.ReadLine() );

            myAccount.Deposit( userInput );

            Console.WriteLine($"Current Balance: ${myAccount.GetBalance()}");

        }
    }
}
