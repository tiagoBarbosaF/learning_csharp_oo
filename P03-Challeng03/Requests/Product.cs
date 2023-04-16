namespace P03_Challeng03.Requests;

public class Product
{
  public string Name;
  public double Value;
  public int Quantity;

  public override string ToString()
  {
    return $" - Name: {Name}" +
           $"\n - Value: {Value:F}" +
           $"\n - Quantity: {Quantity}";
  }
}