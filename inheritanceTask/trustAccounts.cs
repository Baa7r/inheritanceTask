using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceTask
{
    internal class trustAccounts : savingAccounts
    {
        public int bonus { get; set; }
        public int withdrawalCount { get; set; }
        public int MaxWithdrawalsPerYear  { get; set; }
        public DateTime firstWithdraw { get; set; }
        public DateTime newWithdraw { get; set; }


        public double MaxWithdrawalPercentage { get; set; }
        public trustAccounts(string name = "mohamed" , double balance = 5000, double intrate = 0.05 , int bonus = 50 , int MaxWithdrawalsPerYear = 3 , double MaxWithdrawalPercentage = 0.2   )
           : base(name, balance, intrate)
        {
            this.bonus = bonus;
            this.MaxWithdrawalsPerYear = MaxWithdrawalsPerYear;
            this.withdrawalCount = 0;

        }


        public override bool Deposite(double amount)
        {
            if ( amount >= 5000)
            {
                return base.Deposite(amount + bonus);
            }
            return base.Deposite(amount); 
        }

        public override bool withDraw(double amount)
        {

           

            
                if (withdrawalCount >= MaxWithdrawalsPerYear)
                {
                    Console.WriteLine($"Withdrawal limit exceeded. Only 3 withdrawals are allowed per year. come agin on{newWithdraw}");
                    return false;
                }
                

                if (amount > balance * MaxWithdrawalPercentage)
                {
                    Console.WriteLine("Withdrawal amount exceeds 20% of account balance.");
                    return false;
                }

                if (base.withDraw(amount))
                {
                    withdrawalCount++;

                if (withdrawalCount == 1)
                {
                    firstWithdraw = DateTime.Now;
                    newWithdraw = firstWithdraw.AddYears(1);
                }

                Console.WriteLine($"Withdrawal successful. You have {MaxWithdrawalsPerYear - withdrawalCount} withdrawals left this year.");
                    return true;
                }

            
            return false;









        }

    }
}
