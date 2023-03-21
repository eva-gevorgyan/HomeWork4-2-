namespace DelEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
           BankCard bankCard = new BankCard(150);
            //Console.WriteLine($"{bankCard.Balance}");    
            //bankCard.Add(50);
            //Console.WriteLine($" Add {bankCard.Balance}");
            //bankCard.Remove(50);
            //Console.WriteLine($" Remove {bankCard.Balance}");
            bankCard.Message += showMessage;
            bankCard.Add(50);
            bankCard.Remove(450);
            static void showMessage(string message)
            {
                Console.WriteLine(message);
            }
        }
    }
}