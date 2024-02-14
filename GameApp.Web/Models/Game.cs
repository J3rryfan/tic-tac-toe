namespace GameApp.Web.Models;


public class Game
{
  
  public int GameId { get; set; }

  public string Player1Id { get; set; } = "";
  public string Player2Id { get; set; } = "";

  public string[,] BoardState { get; set; } = new string[3,3];

  public string CurrentTurnId { get; set; } = "";

  public GameStatus Status { get; set; }


  public string WinnerId { get; set; } = "";

}

public enum GameStatus
{
    WaitingForPlayer,
    InProgress,
    Completed,
    Draw
}