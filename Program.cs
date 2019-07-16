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

      Branches O = new Branches("bedroom", "You wake up in your bedroom in a daze. After a few minutes on your phone, you deceide to go to the (bathroom = 1 / downstairs = 2)", 0, true);
      Branches O1 = new Branches("bathroom", "As you are relieving yourself, you hear a deep rumble coming from inside the bathroom closet. Do you explore the closet or panic and jump out of the window beside the toilet? (closet = 4 / window = 3)", 1, true);
      Branches O2 = new Branches("downstairs", "You wake up in your bedroom", 2, true);
      Branches O1A = new Branches("window", "The sound of the rumbling closet overwhelms your senses. You frantically jump out of the nearby window for safety, but unfortunately fall face first and die. GAME OVER.", 3, false);
      Branches O1B = new Branches("closet", "You wake up in your bedroom", 4, true);
      Branches O2A = new Branches("kitchen", "You wake up in your bedroom", 5, true);
      Branches O2B = new Branches("living room", "You wake up in your bedroom", 6, true);

      List<Branches> Tree = new List<Branches>() { O, O1, O2, O1A, O1B, O2A, O2B };

      while(storyActive == true)
      {
        storyActive = Tree[currentBranch].GetStoryState();
        Console.WriteLine(Tree[currentBranch].GetBranch());
        currentBranch = int.Parse(Console.ReadLine());
      }

    }
  }
}
