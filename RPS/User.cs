public class User
{
  public string Name { get; set; }
	public int Input { get; set; }
	
	public User(string name, int input)
	{
		Name = name;
		Input = input;
	}
	public void PrintUserName()
	{
		Console.WriteLine("Player is: {0}",Name);
	}
	public void PrintUserInput()
	{
		Console.WriteLine("Player input is: {0}",Input);
	}
}