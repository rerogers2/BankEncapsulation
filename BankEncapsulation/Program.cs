namespace BankEncapsulation
{
    public class Program
    {
        public static double askDeposit()
        {
            Console.WriteLine("How much would you like to deposit?");
            double deposit = Convert.ToDouble(Console.ReadLine());
            return deposit;
        }
        
        static void Main(string[] args)
        {
            // create a user with a BankAccount
            BankAccount user = new BankAccount();

            // ask for money to deposit
            user.Deposit(Convert.ToDouble(askDeposit()));

            // give balance
            Console.WriteLine($"Your balance is currently:\n{user.GetBalance(), 0:C}");
        }
    }
}
