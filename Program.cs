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

      //string areaName, string initialBranchStory, string afterBranchStory, string movementChoices, int branchId, bool lobbyReturn, bool visited

      Branches X = new Branches("walk", "It's a cold night in late November, 1999. You're out on your nightly walk down the old dirt and rock path behind your house in the countryside, earbuds playing 'Bye-Bye-Bye' by Nsync via your Sony Walkman. Midway through your stroll, an unfamiliar object catches your eye on the horizon. There appears to be a new yet strangely old house residing on a hillside you've walked by countless times before...", "You're not supposed to be back here...", "(approach house = 1 / return home = 2)", 0, false, false);
      
      Branches X1 = new Branches("mansion", "You approach the house and enter the front door. To the left appears to be a living room filled with old, dusty furniture. Straight ahead is a kitchen, eminating heat and light. To the right is a staircase leading to the second floor.", "You are in the lobby of the old house.", "(living room = 3, kitchen = 4, upstairs = 5)", 1, false, false);
      
      Branches X2 = new Branches("home", "You decide not to investigate the suspicious house and instead finish your walk. You approach your home and begin to reach down towards the brass handle on the front door you just recently polished, when a cold chill overcomes your entire body... Everything goes dark." , "2nd visit", "", 2, true, false);
      
      Branches X1A = new Branches("living room", "You make your way into the house's living room. Every step incurs a new creek in the old wood floorboards. To the left is a library and to the right there appears to be a strange set of reflections.", "You make your way back into the living room. To the left is a library and to the right there appears to be a strange set of reflections.", "(library = 6, mirror room = 7, lobby = 1)", 3, false, false);
      
      Branches X1B = new Branches("kitchen", "As you slowly approach the kitchen, you feel the heat getting more and more intense. The light is coming from an open fridge, with a lone cup of yogurt present. To the far end of the kitchen, there is a door leading downstairs.", "2nd visit", "(approach fridge = 12, go to cellar = 11, lobby = 1)", 4, false, false);
      
      Branches X1C = new Branches("upstairs", "You ascend the cobweb covered staircase, inspecting the old family portraits that litter the walls. Their faces obscured by time, and strangely still, they appear to be looking right back at you. To the right you see the entrance to a bedroom. Above you is a latch opening up to the attic.", "2nd visit", "(bedroom = 21, attic = 18, lobby = 1)", 5, false, false);
      
      Branches X1A1 = new Branches("library", "You enter the library and are overtaken by the sheer number of books. Each shelf is filled to the brim.", "2nd visit", "(bookshelf = 8, living room = 3)", 6, false, false);
      
      Branches X1A2 = new Branches("mirror room", "You look into the giant mirror. The dust layer is so thick that it prevents it from casting a reflection. You reach out and push aside the ancient dust and grime.", "2nd visit", "(You see yourself smile in the reflection = 9, You see yourself cry = 10)", 7, false, false);
      
      Branches X1A1A = new Branches("bookshelf", "You walk towards the bookshelf. Title after title you recognize; this library feels as though it is yours. All of your favorites, and other stories you've wished to read but previously haven't had the time to. You grab the one book with a title you do not recognize, named 'My Story'. You open it and find that every page is empty white. Everything goes white...", "2nd visit", "", 8, true, false);
      
      Branches X1A2A = new Branches("happy reflection", "The mirror shines and reveals an image of paradise. It looks like the mnirror is a window to heaven itself. You reach out yet you cannot get past the glass. Of course you can't. Mirrors do not work that way. You have a feeling that you aren't worthy of such a place. You see that the mirror shifts into an image of the mansion.", "2nd visit", "", 9, true, false);
      
      Branches X1A2AB = new Branches("sad reflection", "The mirror grows dark and reveals an image of suffering. Your face twists in fear. You look around and the walls in the room melt away. Your body begins to fade as the world starts to burn. Everything bocomes hot. Everything becomes dark.", "2nd visit", "", 10, true, false);
      
      Branches X1B1 = new Branches("cellar", "You make your way down the moldy gaping entrance of what you assume is the cellar. The air is thick with rot, fermented many times over. You see another entrane adorned with iron bars that long rotted off the walls. You also see a candlestick hanging out of a wall that looks a little too unique.", "2nd visit", "Go into the dungeon = 13, inspect the candlestick = 15", 11, false, false);

      Branches X1B2 = new Branches("yogurt", "A strange presence overtakes you, and you feel as if you've lost all control over your body as you spoon the yogurt ferociously into your mouth... Some time passes and you feel awful, collapsing to the kitchen floor...", "2nd visit", "", 12, true, false);
      
      Branches X1B1A = new Branches("dungeon", "You enter the family friendly dungeon. Nothing bad ever happened here. A bad guy used to live here and he's a big meany.", "2nd visit", "(Go to the Altar = 14)", 13, false, false);
      
      Branches X1B1A1 = new Branches("altar", "You wake up in your bedroom", "2nd visit", "movement choice", 14, false, false);
      
      Branches X1B1A1A = new Branches("candlestick", "You wake up in your bedroom", "2nd visit", "movement choice", 15, false, false);
      
      Branches X1B1A1B = new Branches("knife", "You wake up in your bedroom", "2nd visit", "movement choice", 16, false, false);
      
      Branches X1B1A1A1 = new Branches("coffin", "You wake up in your bedroom", "2nd visit", "movement choice", 17, false, false);
      
      Branches X1C1 = new Branches("attic", "You wake up in your bedroom", "2nd visit", "movement choice", 18, false, false);
      
      Branches X1C1A = new Branches("roof", "You wake up in your bedroom", "2nd visit", "movement choice", 19, false, false);
      
      Branches X1C1A1 = new Branches("ledge", "You wake up in your bedroom", "2nd visit", "movement choice", 20, false, false);
      
      Branches X1C2 = new Branches("bedroom", "You wake up in your bedroom", "2nd visit", "movement choice", 21, false, false);
      
      Branches X1C2A = new Branches("closet", "You wake up in your bedroom", "2nd visit", "movement choice", 22, false, false);
      
      Branches X1C2B = new Branches("bathroom", "You wake up in your bedroom", "2nd visit", "movement choice", 23, false, false);
      
      Branches X1C2B1 = new Branches("tub", "You wake up in your bedroom", "2nd visit", "movement choice", 24, false, false);

      List<Branches> Tree = new List<Branches>() { X, X1, X2, X1A, X1B, X1C, X1A1, X1A2, X1A1A, X1A2A, X1A2AB, X1B1, X1B2, X1B1A, X1B1A1, X1B1A1A, X1B1A1B, X1B1A1A1, X1C1, X1C1A, X1C1A1, X1C2, X1C2A, X1C2B, X1C2B1 };

      while(storyActive == true)
      {
        // Console.WriteLine(currentBranch);
        if(Tree[currentBranch].Visited) {
          Console.WriteLine(Tree[currentBranch].AfterBranchStory);
        } else {
          Console.WriteLine(Tree[currentBranch].InitialBranchStory);
          Tree[currentBranch].Visited = true;
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(Tree[currentBranch].MovementChoices);
        Console.ResetColor();

        if(Tree[currentBranch].LobbyReturn) {
          System.Threading.Thread.Sleep(5000);
          currentBranch = 1;
          Tree[currentBranch].LobbyReturn = false;
          Console.WriteLine("You appear to have awaken in the lobby of the old house...");
        } else {
          currentBranch = int.Parse(Console.ReadLine());

          if(currentBranch == 2) 
          {
            Tree[1].Visited = true;
          } else if (currentBranch == 1) 
          {
            Tree[2].LobbyReturn = false;
          }
        }
        storyActive = checkStoryActive(Tree);

      }
      Console.WriteLine("You have discovered the horrible truth. You were dead all along!!! 😭");
    }

    static bool checkStoryActive(List<Branches> Tree)
    {
      bool storyState = true;
      for(int i = 0; i < Tree.Count; i++)
      {
          if(Tree[i].LobbyReturn == false)
          {
            storyState = false;
          } else {
            storyState = true;
            return storyState;
          }
      }
      return storyState;
    }
  }
}
