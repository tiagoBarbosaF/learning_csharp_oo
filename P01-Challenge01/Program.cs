using P01_Challenge01;

Products product = new Products
{
  Name = "Milk",
  Manufacturer = "Piracanjuba",
  BarCode = "84A05068-B196-43BA-81FD-72D52E946620",
  UnityValue = 6.50,
  BuyValue = 3.50,
  QuantityStock = 150
};

Console.WriteLine(
  "Name: " + product.Name +
  "\nManufacturer: " + product.Manufacturer +
  "\nBarCode: " + product.BarCode +
  "\nUnityValue: " + product.UnityValue.ToString("F") +
  "\nBuyValue: " + product.BuyValue.ToString("F") +
  "\nQuantityStock: " + product.QuantityStock
);