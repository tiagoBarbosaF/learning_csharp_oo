namespace AnyBank.Exceptions;

public class FinancialOperationException : Exception
{
  public FinancialOperationException(string message) : base(message)
  {
    
  }
  
  public FinancialOperationException(string message, Exception innerException) : base(message, innerException)
  {
    
  }
}