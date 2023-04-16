namespace AnyBank;

public class FileReader : IDisposable
{
  public string File { get; private set; }

  public FileReader(string file)
  {
    File = file;
    Console.WriteLine($"Opening file: {file}");
  }

  public string ReadNextLine()
  {
    Console.WriteLine($"Reading line...");
    throw new IOException("Reading file interrupted.");
    return $"File line";
  }

  public void Dispose()
  {
    Console.WriteLine($"Closing file.");
  }
}