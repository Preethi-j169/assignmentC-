using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_Csharp
{
    class bank
    {
        int min_balance, balance1;
        public bank(int balance1)
        {
            min_balance = 500;
            this.balance1 = balance1;
        }
        public static void Main ()
        {
            bank balance = new bank(501);
            Console.WriteLine("default_balance=" + balance.min_balance);
            Console.WriteLine("new_balance=" + balance.balance1);
        }
    }

}

