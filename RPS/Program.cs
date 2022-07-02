// See https://aka.ms/new-console-template for more information
public class Program
{
  public static void Main(string[] args)
  {
    //---------------------User Input--------------------------------------------//
    Console.WriteLine("Hi, We are ready to start the game!");
    Console.WriteLine("Enter your Name: ");
    string name = Console.ReadLine();
    Console.WriteLine("Enter your choose(rock-1/paper-2/sciccors-3): ");
    int input = Convert.ToInt32(Console.ReadLine());
    var user = new User(name, input);
    //----------------ComputerInput-------------------------------------------------//
    Random random = new Random();
    int index = random.Next(1, UserChoose.Values.Count+1);
    string compName = "Computer";
    var computer = new User(compName, index);

    var game = new Game(user, computer);
    user.PrintUserName();
    user.PrintUserInput();
    computer.PrintUserName();
    computer.PrintUserInput();
    game.PrintWinner();


  }
}
