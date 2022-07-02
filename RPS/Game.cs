public class Game
{
  public User userResult { get; set; }
  public User compResult { get; set; }

  public Game(User userresult, User compresult)
	{
		userResult = userresult;
		compResult = compresult;
	}

  public string DecideTheWinner()
  {
    if(this.userResult.Input == this.compResult.Input)
    {
      return "DRAW";
    }

    if(this.userResult.Input == 1)
    {
      if(this.compResult.Input == 2)
        return this.compResult.Name;
      else
        return this.userResult.Name;
    }

    if(this.userResult.Input == 2)
    {
      if(this.compResult.Input == 1)
        return this.userResult.Name;
      else
        return this.userResult.Name;
    }

    if(this.userResult.Input == 3)
    {
      if(this.compResult.Input == 1)
        return this.compResult.Name;
      else
        return this.userResult.Name;
    }
    
    
    return "NaN";
  }

  public void PrintWinner()
  {
    Console.WriteLine("The winner is: {0}", this.DecideTheWinner());
  }
    
}

