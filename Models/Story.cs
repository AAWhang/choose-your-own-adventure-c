using System;

namespace Adventure.Branch
{
  class Branches
  {
    private string _areaBriefDesc;
    private string _branch;
    private int _branchId;
    private bool _storyState;

    public Branches(string areaBriefDesc, string branch, int branchId, bool storyState)
    {
      _areaBriefDesc = areaBriefDesc;
      _branch = branch;
      _branchId = branchId;
      _storyState = storyState;
    }

    public string GetBranch()
    {
      return _branch;
    }

    public bool GetStoryState()
    {
      return _storyState;
    }

  }
}
