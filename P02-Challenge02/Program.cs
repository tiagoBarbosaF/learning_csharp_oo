using P02_Challenge02;

Person person = new Person
{
  Name = "Bob",
  Age = 32,
  Heigth = 1.82f,
  Weigth = 90.300f
};

Console.WriteLine($"Name: {person.Name}" +
                  $"\nAge: {person.Age}" +
                  $"\nHeigth: {person.Heigth:F}" +
                  $"\nWeigth: {person.Weigth:F3}");