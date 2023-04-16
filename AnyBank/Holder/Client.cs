namespace AnyBank.Holder;

public class Client
{
  public string Name { get; }
  public string Cpf { get; }
  public string Profession { get; }

  public Client(string name, string cpf, string profession)
  {
    Name = name;
    Cpf = cpf;
    Profession = profession;
  }
}