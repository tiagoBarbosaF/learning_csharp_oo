namespace AnyBank.Exceptions;

public class InsufficientFundsException : FinancialOperationException
{
  public InsufficientFundsException(string message) : base(message)
  {
    
  }
}