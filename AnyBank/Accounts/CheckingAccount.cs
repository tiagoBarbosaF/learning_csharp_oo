using AnyBank.Holder;

namespace AnyBank;

public class CheckingAccount
{
  public static int TotalAccountsCreated { get; private set; }

  public static double OperationFee { get; private set; }

  private int _agencyNumber;

  private int AgencyNumber
  {
    get => _agencyNumber;
    set
    {
      if (value > 0)
        _agencyNumber = value;
    }
  }

  private string Account { get; }
  private Client Holder { get; }
  private double Balance { get; set; }

  public CheckingAccount(int agencyNumber, string account, Client holder)
  {
    if (agencyNumber <= 0)
    {
      throw new ArgumentException("Not permitted agency number less or equal zero.", nameof(agencyNumber));
    }
    else
    {
      AgencyNumber = agencyNumber;
    }

    Account = account;
    Holder = holder;
    // try
    // {
    //   OperationFee = 30 / TotalAccountsCreated;
    // }
    // catch (DivideByZeroException e)
    // {
    //   Console.WriteLine($"{e.Message}" +
    //                     $"\n{e.StackTrace}");
    // }
    TotalAccountsCreated++;
  }

  public void Deposit(double value)
  {
    if (value < 0)
    {
      return;
    }

    Balance += value;
  }

  public bool Withdraw(double value)
  {
    if (value <= Balance)
    {
      Balance -= value;
      return true;
    }
    else
    {
      return false;
    }
  }

  public bool Transfer(double value, CheckingAccount accountDeposit)
  {
    if (Balance < value)
    {
      return false;
    }
    else
    {
      Withdraw(value);
      accountDeposit.Deposit(value);
      return true;
    }
  }

  public override string ToString()
  {
    return $"Agency Number: {AgencyNumber}" +
           $"\nAccount: {Account}" +
           $"\nHolder: " +
           $"\n - Name: {Holder!.Name}" +
           $"\n - Cpf: {Holder!.Cpf}" +
           $"\n - Profession: {Holder!.Profession}" +
           $"\nBalance: {Balance:F}";
  }
}