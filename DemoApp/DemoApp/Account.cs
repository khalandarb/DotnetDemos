using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp
{
    class Account
    {
        long AccNo;
        double bal;
        string[] payees;
        long[] payeesAccount;

        public Account(long AccNo,double bal)
        {
            this.AccNo = AccNo;
            this.bal = bal;
        }

        public Account(long AccNo,double bal,string[] payees,long[] payeesAccount)
        {
            this.AccNo = AccNo;
            this.bal = bal;
            this.payees = payees;
            this.payeesAccount = payeesAccount;
        }

        public bool DebitAmount(double Amount)
        {
            if (Amount <= this.bal)
            {
                 this.bal = this.bal - Amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TransferMoney(long payeeAccNo,double amount)
        {
            foreach(var item in payeesAccount)
            {
                DebitAmount(amount);
                return true;
            }
            return false;
        }
        
        public bool TransferMoney(string payee,double amount)
        {
            foreach(var item in payees)
            {
                DebitAmount(amount);
                return true;
            }
            return false;
        }
        

    }
}
