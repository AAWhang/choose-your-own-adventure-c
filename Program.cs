using System;
using System.Collections.Generic;
using Adventure.Branch;

namespace Adventure
{
  public class Program
  {
    public static void Main()
    {
      bool storyActive = true;
      int currentBranch = 0;

      //string areaName, string initialBranchStory, string afterBranchStory, string choiceDesc, string movementChoices, int branchId, bool lobbyReturn

      Branches X = new Branches("walk", "It's a cold night in late November, 1999. You're out on your nightly walk down the old dirt and rock path behind your house in the countryside, earbuds playing 'Bye-Bye-Bye' by Nsync via your Sony Walkman. Midway through your stroll, an unfamiliar object catches your eye on the horizon. There appears to be a new yet strangely old house residing on a hillside you've walked by countless times before...", "2nd visit", "(approach house = 1 / return home = 2)", "choice desc", 0, false, false);
      Branches X1 = new Branches("mansion", "You approach the house and enter the front door.", "You appear to have awaken in the foyer of the old house...", "(living room = 3, kitchen = 4, old house = 5)", "choice desc", 1, false, false);
      Branches X2 = new Branches("home", "You decide not to investigate the suspicious house and instead finish your walk. You approach your home and begin to reach down towards the brass handle on the front door you just recently polished, when a cold chill overcomes your entire body... Everything goes dark." , "2nd visit", "", "choice desc", 2, true, false);
      Branches X1A = new Branches("living room", "The sound of the rumbling closet overwhelms your senses. You frantically jump out of the nearby window for safety, but unfortunately fall face first and die. GAME OVER.", "2nd visit", "movement choice", "choice desc", 3, false, false);
      Branches X1B = new Branches("kitchen", "You wake up in your bedroom", "2nd visit", "movement choice", "choice desc", 4, false, false);
      Branches X1C = new Branches("upstairs", "You wake up in your bedroom", "2nd visit", "movement choice", "choice desc", 5, false, false);
      Branches X1A1 = new Branches("library", "You wake up in your bedroom", "2nd visit", "movement choice", "choice desc", 6, false, false);
      Branches X1A2 = new Branches("mirror room", "You wake up in your bedroom", "2nd visit", "movement choice", "choice desc", 7, false, false);
      Branches X1A1A = new Branches("bookshelf", "You wake up in your bedroom", "2nd visit", "movement choice", "choice desc", 8, false, false);
      Branches X1A2A = new Branches("happy reflection", "You wake up in your bedroom", "2nd visit", "movement choice", "choice desc", 9, false, false);
      Branches X1A2AB = new Branches("sad reflection", "You wake up in your bedroom", "2nd visit", "movement choice", "choice desc", 10, false, false);
      Branches X1B1 = new Branches("cellar", "You wake up in your bedroom", "2nd visit", "movement choice", "choice desc", 11, false, false);
      Branches X1B1A = new Branches("dungeon", "You wake up in your bedroom", "2nd visit", "movement choice", "choice desc", 12, false, false);
      Branches X1B1A1 = new Branches("altar", "You wake up in your bedroom", "2nd visit", "movement choice", "choice desc", 13, false, false);
      Branches X1B1A1A = new Branches("candlestick", "You wake up in your bedroom", "2nd visit", "movement choice", "choice desc", 14, false, false);
      Branches X1B1A1B = new Branches("knife", "You wake up in your bedroom", "2nd visit", "movement choice", "choice desc", 15, false, false);
      Branches X1B1A1A1 = new Branches("coffin", "You wake up in your bedroom", "2nd visit", "movement choice", "choice desc", 16, false, false);
      Branches X1C1 = new Branches("attic", "You wake up in your bedroom", "2nd visit", "movement choice", "choice desc", 17, false, false);
      Branches X1C1A = new Branches("roof", "You wake up in your bedroom", "2nd visit", "movement choice", "choice desc", 18, false, false);
      Branches X1C1A1 = new Branches("ledge", "You wake up in your bedroom", "2nd visit", "movement choice", "choice desc", 19, false, false);
      Branches X1C2 = new Branches("bedroom", "You wake up in your bedroom", "2nd visit", "movement choice", "choice desc", 20, false, false);
      Branches X1C2A = new Branches("closet", "You wake up in your bedroom", "2nd visit", "movement choice", "choice desc", 21, false, false);
      Branches X1C2B = new Branches("bathroom", "You wake up in your bedroom", "2nd visit", "movement choice", "choice desc", 22, false, false);
      Branches X1C2B1 = new Branches("tub", "You wake up in your bedroom", "2nd visit", "movement choice", "choice desc", 23, false, false);

      List<Branches> Tree = new List<Branches>() { X, X1, X2, X1A, X1B, X1C, X1A1, X1A2, X1A1A, X1A2A, X1A2AB, X1B1, X1B1A, X1B1A1, X1B1A1A, X1B1A1B, X1B1A1A1, X1C1, X1C1A, X1C1A1, X1C2, X1C2A, X1C2B, X1C2B1 };

      while(storyActive == true)
      {
        Console.WriteLine(currentBranch);
        if(Tree[currentBranch].Visited) {
          Console.WriteLine(Tree[currentBranch].AfterBranchStory);
        } else {
          Console.WriteLine(Tree[currentBranch].InitialBranchStory);
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(Tree[currentBranch].MovementChoices);
        Console.ResetColor();
        if(Tree[currentBranch].LobbyReturn) {
          System.Threading.Thread.Sleep(4000);
          currentBranch = 1; 
        } else {
          currentBranch = int.Parse(Console.ReadLine());
          if(currentBranch == 2) {
            Tree[1].Visited = true;
          }
        }
      }

    }
  }
}
