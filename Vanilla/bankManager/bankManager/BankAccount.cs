//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace bankManager
//{
//    internal class BankAccount
//    {
//    }
//}


using System;

public class BankAccount
{
    // This property holds the account number (e.g., "12345").
    public string AccountNumber { get; set; }

    // This property holds the name of the account holder (e.g., "John Doe").
    public string AccountHolder { get; set; }

    // The balance property shows how much money is in the account.
    // Notice the 'private set' - it means only the BankAccount class can change this value.
    public double Balance { get; private set; }

    // Constructor: This is a special method that is called when a new BankAccount object is created.
    public BankAccount(string accountNumber, string accountHolder, double balance)
    {
        AccountNumber = accountNumber;  // Assign the account number.
        AccountHolder = accountHolder;  // Assign the account holder's name.
        Balance = balance;              // Set the starting balance.
    }

    // Method to deposit money into the account.
    public void Deposit(double amount)
    {
        Balance += amount;  // Add the amount to the balance.
    }
    
    // Method to withdraw money form the account.
    public void withdraw(double amount)
{
    // Check if the account has enought money.
    if (amount <= Balance)
    {
        Balance -= amount;  // Subtract the amount from the balance.
    }
    else
    {
        // Show an error if not enough money.
        throw new InvalidOperationException("Insufficient funds");
    }
}

// Method to display account information (like a summary).
public override string ToString()
{
    // Return a string showing account number, holder name, and balance.
    return $"Account Number: {AccountNumber}, " +
            $"Holder: {AccountHolder}," +
            $" Balance: {Balance:C}";
}
}