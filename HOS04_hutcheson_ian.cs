using System;

public class BankAccount
{
    private decimal balance; //define balance function

    public BankAccount(decimal initialBalance) //define initial balance
    {
        balance = initialBalance;
    }

    public void Deposit(decimal amount) //define deposit function
    {
        if (amount > 0) //if statement to check whether deposit amount is above zero
        {
            balance += amount; //if yes, add deposit amount to existing balance
            Console.WriteLine($"Deposited: {amount}, New Balance: {balance}"); //write result to console
        }
    }

    public bool Withdraw(decimal amount) //define withdraw function
    {
        if (amount > balance) //if statement to check whether requested amount is larger than available balance
        {
            Console.WriteLine("Insufficient funds."); //advise user of insufficient funds
            return false; //do not make any updates to balance
        }
        else if (amount <= 0) //else if statement to check whether requested amount is less than or equal to zero
        {
            Console.WriteLine("Withdrawal amount must be positive."); //advise user of withdrawal requirement
            return false; //do not make any updates to balance
        }
        else //if neither of the above apply...
        {
            balance -= amount; //subtract withdrawal amount from balance
            Console.WriteLine($"Withdrew: {amount}. New Balance: {balance}");//write result to console
            return true; //modify balance
        }
    }

    public decimal GetBalance() //define function to check on current balance
    {
        return balance; //return the current balance
    }


    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount(1000); //define initial bank account balance as $1000

            myAccount.Deposit(500); //deposit 500

            if (myAccount.Withdraw(200)) //check whether withdrawal attempt is $200
            {
                Console.WriteLine($"Withdrawal successful. Current balance: {myAccount.GetBalance()}"); //if yes, print result to console
            }
            else
            {
                Console.WriteLine("Withdrawal failed."); //advise user of failure.
            }
        }
    }
}