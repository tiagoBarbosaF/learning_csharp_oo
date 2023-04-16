using P03_Challeng03.Clients;

namespace P03_Challeng03.Requests;

public class Request
{
  public Client Client;
  public Product[] Product;

  public override string ToString()
  {
    return $"Request: " +
           $"\n- Name: {Client.Name}" +
           $"\n- Address: {Client.Address.Street}, {Client.Address.Number} - {Client.Address.Neighborhood}, {Client.Address.City}" +
           $"\n- Itens:";
  }
}