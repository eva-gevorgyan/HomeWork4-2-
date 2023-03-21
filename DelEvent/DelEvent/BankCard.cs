using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelEvent
{
    internal class BankCard
    {
        public int Balance { get; set; }
        public BankCard(int Balance)
        {
            this.Balance = Balance;
        }
        public void Add(int sum)
        {
            Message.Invoke($"+ {sum}");
            Balance += sum;
            Message.Invoke($"Your balance - {Balance}");
        }
        public void Remove(int sum)
        {
            if (Balance > sum)
            {
                Message.Invoke($"- {sum}");
                Balance -= sum;
                Message.Invoke($"Your balance - {Balance}");
            }
            else
            {
                Message.Invoke("Not enough");
                Message.Invoke($"Your balance - {Balance}");
            }
        }
        public delegate void MyDelegate(string message);
        public event MyDelegate Message;
    }
}
