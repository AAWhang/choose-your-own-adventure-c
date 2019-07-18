namespace Adventure.Branch
{
  class Branches
  {
  
    public string AreaName { get; set; }
    public string InitialBranchStory { get; set; }
    public string AfterBranchStory { get; set; }
    public string MovementChoices { get; set; }
    public int BranchId { get; set; }
    public bool LobbyReturn { get; set; }
    public bool Visited { get; set; }

    public Branches(string areaName, string initialBranchStory, string afterBranchStory, string movementChoices,  int branchId, bool lobbyReturn, bool visited)
    {
      AreaName = areaName;
      InitialBranchStory = initialBranchStory;
      AfterBranchStory = afterBranchStory;
      MovementChoices = movementChoices;
      BranchId = branchId;
      LobbyReturn = lobbyReturn;
      Visited = visited;

    }

  }
}
