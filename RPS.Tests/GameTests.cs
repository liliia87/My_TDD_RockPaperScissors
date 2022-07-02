global using NUnit.Framework;
namespace RPS.Tests;

public class GameTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GameChooseTheWinner_UserPaperGameRock()
    {
        var user = new User("A1", 2);
        var computer = new User("A2", 1); 
        Game game = new Game(user, computer);
        var winner = game.DecideTheWinner();

        Assert.AreEqual("A1", winner);

    }

    [Test]
    public void GameChooseTheWinner_UserRockGameRock()
    {
        var user = new User("A1", 1);
        var computer = new User("A2", 1); 
        Game game = new Game(user, computer);
        var winner = game.DecideTheWinner();

        Assert.AreEqual("DRAW", winner);

    }

    [Test]
    public void GameChooseTheWinner_UserSiccorsGameRock()
    {
        var user = new User("A1", 3);
        var computer = new User("A2", 1); 
        Game game = new Game(user, computer);
        var winner = game.DecideTheWinner();

        Assert.AreEqual("A2", winner);

    }
    
    [Test]
     public void GameChooseTheWinner_UserSiccorsGameSiccors()
    {
        var user = new User("A1", 3);
        var computer = new User("A2", 3); 
        Game game = new Game(user, computer);
        var winner = game.DecideTheWinner();

        Assert.AreEqual("DRAW", winner);

    }
}