using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceTask
{
    internal class savingAccounts : Accounts
    {
        public double  IntRate { get; set; }

        public savingAccounts( string name = "mohamed" , double balance =500, double intrate = 0.05)
            :base( name , balance)
        {
            this.IntRate = intrate;
        }



        public override bool withDraw(double amount)
        {

            return base.withDraw(amount + IntRate);
        }
    }
}
