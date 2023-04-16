using AnyBank;
using AnyBank.Exceptions;
using AnyBank.Holder;


#region Part.01

// CheckingAccount account2 = new CheckingAccount(16,"1011-X",new Client("José Silva", "11111111111", "Developer"));
//
// try
// {
//   CheckingAccount account1 = new CheckingAccount(10, "1010-X", new Client("André Silva", "11111111111", "Developer"));
//   account1.Withdraw(150);
//   Console.WriteLine(account1);
// }
// catch (ArgumentException e)
// {
//   Console.WriteLine($"Invalid argument: {e.ParamName}" +
//                     $"\nMessage: {e.Message}" +
//                     $"\nCall Stack: {e.StackTrace}");
// }
// catch (InsufficientFundsException ex)
// {
//   Console.WriteLine(ex.Message);
// }

#endregion


using (FileReader reader = new FileReader("accounts.txt"))
{
  reader.ReadNextLine();
  reader.ReadNextLine();
}


FileReader reader2 = new FileReader("employees.txt");
try
{
  reader2.ReadNextLine();
  reader2.ReadNextLine();
}
catch (IOException e)
{
  Console.WriteLine(e.Message);
}
finally
{
  reader2.Dispose();
}