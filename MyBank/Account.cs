using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{

    public enum TypeOfAccounts
    {
        Checking,
        Savings
    }
    /// <summary>
    /// This class describes a bank account
    /// 
    /// </summary>
    public class Account
    {
        #region Statics
        private static int lastAccountNumber = 0;
        #endregion

        #region Properties
        /// <summary>
        /// Account number of the account
        /// </summary>
        public int AccountNumber {
            get;
            private set; }
        /// <summary>
        /// Email address of the user
        /// </summary>
        public string EmailAddress{ get; set; }
        public decimal Balance {
            get;
            private set; }
        public TypeOfAccounts AccountType { get; set; }
        #endregion

        #region Constructors

        public Account()
        {
            //lastAccountNumber++;
            //AccountNumber = lastAccountNumber;

            AccountNumber = ++lastAccountNumber;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Deposit money into your account
        /// </summary>
        /// <param name="amount">Amount to be deposited</param>
        /// <returns>The new balance</returns>
        public decimal Deposit (decimal amount)
        {
            //Balance = Balance + amount;
            Balance += amount;
            return Balance;
        }


        public decimal Withdraw(decimal amount)
        {
            if (amount <=Balance)
            {
                Balance -= amount;
            }
            return Balance;

        }

        #endregion

    }
}
