using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceTask
{
    internal class checAccounts :Accounts
    {
        public double fee { get; set; }


        public checAccounts(string name = "mohamed", double balance = 5000, double fee = 1.5)
            : base(name, balance)
        {

            this.fee = fee;
        }

        public override bool withDraw(double amount)
        {

            return base.withDraw(amount + fee);
        }

    }
}
