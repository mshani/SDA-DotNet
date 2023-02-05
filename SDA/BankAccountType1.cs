using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA
{
    internal class BankAccountType1
    {
        private string IBAN { get;}
        public string FullName { get; set; }
        public List<string> AccountHolders { get; set; }
        public string Email { get; set; }
        public string Currency { get; set; }
        public decimal Amount { get; set; }
        public bool IsActive { get; set; }

        public BankAccountType1(
            string iban, 
            string fullName, 
            string email, 
            string currency)
        {
            IBAN = iban;
            FullName = fullName;
            Email = email;
            Currency = currency;
            Amount = 0;
            IsActive = true;
            AccountHolders = new List<string>();
            AccountHolders.Add(fullName);
        }

        public void Deposit(decimal amount)
        {
            if (!IsActive){
                Console.WriteLine("Unable to perform Deposit. Inactive Account");
            }
            else if(amount < 0){
                Console.WriteLine("Deposit Amount not valid");
            }
            else{
                Amount += amount;
                Console.WriteLine("Amount After Deposit: " + Amount);
            }
        }
        public void Withdraw(decimal amount)
        {
            if (!IsActive){
                Console.WriteLine("Unable to perform Withdarwal. Inactive Account");
            }
            else if (Amount >= amount){
                Amount -= amount;
                Console.WriteLine("Amount After Withdrawal: " + Amount);
            }
            else{
                Console.WriteLine("Unable to withdraw amount: "+ amount + " Not enough funds");
            }
        }
        public void GetBalace()
        {
            Console.WriteLine("Actual balance: " + Amount);
        }
        public void SetStatus(bool status)
        {
            IsActive = status;
        }
        public void GetStatus()
        {
            if (IsActive)
            {
                Console.WriteLine("Bank account is active");
            }
            else
            {
                Console.WriteLine("Bank account is NOT active");
            }
        }      
        public void GetAccountHolders()
        {
            Console.WriteLine("*********Account Holder List*********");
            foreach (string element in AccountHolders)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("************************************");
        }       
        public void AddAccountHolder(string newAccHolder)
        {
            AccountHolders.Add(newAccHolder);
            Console.WriteLine("Add Account Holder: " + newAccHolder);
        }
        public void RemoveAccountHolder(string accHolder)
        {
            AccountHolders.Remove(accHolder);
            Console.WriteLine("Remove Account Holder: " + accHolder);
        }
        public bool SearchAccountHolder(string accHolder)
        {
            bool isFound = AccountHolders.Contains(accHolder);
            return isFound;
        }

        public string GetIban()
        {
            return IBAN;
        }
    }
}
