using System.Security.Principal;

namespace inheritanceTask
{
    class Accounts
    {

        public string name { get; set; }

        public double balance { get; set; }


        public static Accounts operator +(Accounts left, Accounts right)
        {
            Accounts account = new Accounts() { balance = left.balance - right.balance };
            return account;
        }

        public Accounts(string name = "none", double balance = 0)
        {

            this.name = name;
            this.balance = balance;
        }

        public virtual bool Deposite(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                return true;
            }
            return false;
        }

        public virtual bool withDraw(double amount)
        {
            if (balance - amount > 0)
            {
                balance -= amount;
                return true;
            }
            return false;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {

            // Accounts
            var accounts = new List<Accounts>();
            accounts.Add(new Accounts());
            accounts.Add(new Accounts("Larry"));
            accounts.Add(new Accounts("Moe", 2000));
            accounts.Add(new Accounts("Curly", 5000));

            AccountUtil.Display(accounts);
            AccountUtil.Deposit(accounts, 1000);
            AccountUtil.Withdraw(accounts, 2000);

            // Savings
            var savAccounts = new List<Accounts>();
            savAccounts.Add(new savingAccounts());
            savAccounts.Add(new savingAccounts("Superman"));
            savAccounts.Add(new savingAccounts("Batman", 2000));
            savAccounts.Add(new savingAccounts("Wonderwoman", 5000, 5.0));

            AccountUtil.Display(savAccounts);
            AccountUtil.Deposit(savAccounts, 1000);
            AccountUtil.Withdraw(savAccounts, 2000);

            // Checking
            var checAccounts = new List<Accounts>();
            checAccounts.Add(new checAccounts());
            checAccounts.Add(new checAccounts("Larry2"));
            checAccounts.Add(new checAccounts("Moe2", 2000));
            checAccounts.Add(new checAccounts("Curly2", 5000));

            AccountUtil.Display(checAccounts);
            AccountUtil.Deposit(checAccounts, 1000);
            AccountUtil.Withdraw(checAccounts, 2000);
            AccountUtil.Withdraw(checAccounts, 2000);

            // Trust
            var trustAccounts = new List<Accounts>();
            trustAccounts.Add(new trustAccounts());
            trustAccounts.Add(new trustAccounts("Superman2"));
            trustAccounts.Add(new trustAccounts("Batman2", 2000));
            trustAccounts.Add(new trustAccounts("Wonderwoman2", 5000, 5.0));
           

            AccountUtil.Display(trustAccounts);
            AccountUtil.Withdraw(trustAccounts, 100);

            AccountUtil.Deposit(trustAccounts, 1000);
            AccountUtil.Deposit(trustAccounts, 6000);
            AccountUtil.Withdraw(trustAccounts, 2000);
            AccountUtil.Withdraw(trustAccounts, 3000);
            AccountUtil.Withdraw(trustAccounts, 500);

            Console.WriteLine();
        }
    }
}
