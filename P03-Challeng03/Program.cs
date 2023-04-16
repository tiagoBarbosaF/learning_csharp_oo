using P03_Challeng03.Clients;
using P03_Challeng03.Requests;

Request request = new Request
{
  Client = new Client
  {
    Name = "Bob",
    Address = new Address
    {
      Street = "Street1",
      Number = "11-1",
      City = "Whatever",
      Neighborhood = "Peace"
    }
  },
  Product = new []
  {
    new Product
    {
      Name = "Hamburguer",
      Value = 5.50,
      Quantity = 1
    },
    new Product
    {
      Name = "Chips",
      Value = 2.80,
      Quantity = 2
    }
  }
};

Console.WriteLine(request);
foreach (var product in request.Product)
{
  Console.WriteLine(product);
}