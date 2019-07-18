namespace Adventure.Branch
{
  class Branches
  {
  
    public string AreaName { get; set; }
    public string InitialBranchStory { get; set; }
    public string AfterBranchStory { get; set; }
    public string MovementChoices { get; set; }
    public string ChoiceDesc { get; set; }
    public int BranchId { get; set; }
    public bool LobbyReturn { get; set; }

    public Branches(string areaName, string initialBranchStory, string afterBranchStory, string movementChoices, string choiceDesc,  int branchId, bool lobbyReturn)
    {
      AreaName = areaName;
      InitialBranchStory = initialBranchStory;
      AfterBranchStory = AfterBranchStory;
      MovementChoices = movementChoices;
      ChoiceDesc = choiceDesc;
      BranchId = branchId;
      LobbyReturn = lobbyReturn;

    }

  }
}
