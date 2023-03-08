namespace MultipleProjectDependency.DataHandler;

public class Handler
{
	public string Read()
	{
		return "Handler.Read()";
	}

	public void Write(string value)
	{
		Console.WriteLine($"Handler.Write({value})");	
	}
}
