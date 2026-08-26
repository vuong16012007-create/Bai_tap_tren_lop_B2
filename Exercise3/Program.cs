using System;

public class BankAccount
{
    private decimal _balance;
    private string _pin;
    private int _failedAttempts;

    public string AccountHolder { get; }
    public bool IsLocked { get; private set; }

    public BankAccount(string accountHolder, decimal initialBalance, string initialPin)
    {
        AccountHolder = accountHolder;
        _balance = initialBalance > 0 ? initialBalance : 0;
        _pin = initialPin;
        _failedAttempts = 0;
        IsLocked = false;
    }

    public bool Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Error: Deposit amount must be positive.");
            return false;
        }

        _balance += amount;
        Console.WriteLine($"Successfully deposited ${amount:0.00}.");
        return true;
    }

    public bool Withdraw(decimal amount, string inputPin)
    {
        if (IsLocked)
        {
            Console.WriteLine("Error: Account is locked due to multiple failed PIN attempts.");
            return false;
        }

        if (inputPin != _pin)
        {
            _failedAttempts++;
            if (_failedAttempts >= 3)
            {
                IsLocked = true;
                Console.WriteLine("Error: Invalid PIN code. Account has been LOCKED for security!");
            }
            else
            {
                Console.WriteLine($"Error: Invalid PIN code. (Attempt {_failedAttempts}/3)");
            }
            return false;
        }

        _failedAttempts = 0;

        if (amount <= 0)
        {
            Console.WriteLine("Error: Withdrawal amount must be positive.");
            return false;
        }

        if (_balance < amount)
        {
            Console.WriteLine("Error: Insufficient funds.");
            return false;
        }

        _balance -= amount;
        Console.WriteLine($"Successfully withdrew ${amount:0.00}.");
        return true;
    }

    public decimal GetBalance(string inputPin)
    {
        if (IsLocked)
        {
            Console.WriteLine("Error: Account is locked due to multiple failed PIN attempts.");
            return -1m;
        }

        if (inputPin != _pin)
        {
            Console.WriteLine("Error: Invalid PIN code.");
            return -1m;
        }

        return _balance;
    }

    public bool ChangePin(string currentPin, string newPin)
    {
        if (IsLocked)
        {
            Console.WriteLine("Error: Account is locked due to multiple failed PIN attempts.");
            return false;
        }

        if (currentPin != _pin)
        {
            Console.WriteLine("Error: Invalid current PIN code.");
            return false;
        }

        if (string.IsNullOrEmpty(newPin) || newPin.Length != 4 || !int.TryParse(newPin, out _))
        {
            Console.WriteLine("Error: New PIN must be exactly 4 digits and numeric.");
            return false;
        }

        _pin = newPin;
        Console.WriteLine("Successfully changed PIN.");
        return true;
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount("John Doe", 500.00m, "1234");
        
        Console.WriteLine($"Account Holder: {account.AccountHolder}");
        
        Console.WriteLine("\n--- 1. Testing Deposit ---");
        account.Deposit(-50m); // Should fail
        account.Deposit(200m); // Should succeed
        
        Console.WriteLine("\n--- 2. Testing Protected Balance View ---");
        account.GetBalance("9999"); // Wrong PIN
        decimal currentBalance = account.GetBalance("1234"); // Correct PIN
     
        Console.WriteLine($"Verified Balance: ${currentBalance:0.00}");
        
        Console.WriteLine("\n--- 3. Testing Lockout Mechanism ---");
        account.Withdraw(100m, "0000"); // Attempt 1 (Wrong)
        account.Withdraw(100m, "1111"); // Attempt 2 (Wrong)
        account.Withdraw(100m, "2222"); // Attempt 3 (Wrong -> Locks Account)
        
        account.Withdraw(100m, "1234"); // Correct PIN, but account is now locked!
        
        Console.WriteLine("\n--- 4. Account Lock Status ---");
        Console.WriteLine($"Is account locked? {account.IsLocked}");
    }
}