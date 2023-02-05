using SDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SDA
{
    internal class BankAccount
    {
        private string email;
        public BankAccount(
            string iban,
            Person primaryholder, 
            string email, 
            string currency
        ) {
            CheckIban(iban);
            CheckAccountHolder(primaryholder);
            Email = email;
            Currency = currency;
            AccountHolders = new List<Person>();
            AccountHolders.Add(primaryholder);
            IsActive = true;
            Balance = 0;        
        }
        public string IBAN { get; private set; }
        public Person PrimaryAccountHolder { get; private set; }
        public List<Person> AccountHolders { get; private set;}
        public string Email {
            get {
                return email; 
            } 
            set{
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)){
                    Console.WriteLine("Invalid email");
                }
                else
                {
                    email = value;
                }
            }
        }
        public string Currency { get; }
        public decimal Balance { get; private set; }
        public bool IsActive { get; private set; }

        public void MakeDeposit(decimal amount)
        {
            if (IsActive)
            {
                Balance += amount;
            }
            else
            {
                Console.WriteLine("Unable to deposit. Account not active");
            }
        }
        public void MakeWithdrawal(decimal amount)
        {
            if (IsActive)
            {
                if (Balance >= amount)
                {
                    Balance -= amount;
                }
                else
                {
                    Console.WriteLine("Not enough funds");
                }
            }
            else
            {
                Console.WriteLine("Unable to withdraw. Account not active");
            }
        }
        public void SetAccountStatus(bool value)
        {
            IsActive = value;
        }
        public void AddAccountHolder(Person person)
        {
            bool isFound = AccountHolders.Contains(person);
            if(!isFound) {
                AccountHolders.Add(person);
            }
        }
        private void CheckIban(string iban)
        {
            if(iban.Length != 13)
            {
                Console.WriteLine("Invalid iban");
            }
            else
            {
                IBAN = iban;
            }
        }
        private void CheckAccountHolder(Person person)
        {
            if (string.IsNullOrEmpty(person.Name) || string.IsNullOrWhiteSpace(person.Name))
            {
                Console.WriteLine("Invalid account holder");
            }
            else
            {
                PrimaryAccountHolder = person;
            }
        }
        
    }
}
