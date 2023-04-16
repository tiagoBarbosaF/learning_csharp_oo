using AnyBank;
using AnyBank.Holder;

CheckingAccount account2 = new CheckingAccount(16,"1011-X",new Client("José Silva", "11111111111", "Developer"));

try
{
  CheckingAccount account1 = new CheckingAccount(0,"1010-X",new Client("André Silva", "11111111111", "Developer"));
}
catch (ArgumentException e)
{
  Console.WriteLine($"Invalid argument: {e.ParamName}" +
                    $"\nMessage: {e.Message}" +
                    $"\nCall Stack: {e.StackTrace}");
}
// Console.WriteLine(CheckingAccount.OperationFee);
