using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceTask
{
    internal class AccountUtil
    {
        // Utility helper functions for Account class

        public static void Display(List<Accounts> accounts)
        {
            Console.WriteLine("\n=== Accounts ==========================================");
            foreach (var acc in accounts)
            {
                Console.WriteLine(acc.name);
            }
        }

        public static void Deposit(List<Accounts> accounts, double amount)
        {
            Console.WriteLine("\n=== Depositing to Accounts =================================");
            foreach (var acc in accounts)
            {
                if (acc.Deposite(amount))
                    Console.WriteLine($"Deposited {amount} to {acc.name}");
                else
                    Console.WriteLine($"Failed Deposit of {amount} to {acc.name}");
            }
        }

        public static void Withdraw(List<Accounts> accounts, double amount)
        {
            Console.WriteLine("\n=== Withdrawing from Accounts ==============================");
            foreach (var acc in accounts)
            {
                if (acc.withDraw(amount))
                    Console.WriteLine($"Withdrew {amount} from {acc.name}");
                else
                    Console.WriteLine($"Failed Withdrawal of {amount} from {acc.name}");
            }
        }

        // Helper functions for Savings Account class

        // Helper functions for Checking Account class

        // Helper functions for Trust account class
    }
}
