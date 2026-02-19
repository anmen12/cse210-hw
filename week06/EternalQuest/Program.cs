//In addition to the core requirements, I added code that will keep track of whether a goal has
//been completed or not. If it has been completed it will be shown seperately when goals are listed
//and will not be shown when asking about reporting an event

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        goalManager.Start();
    }
}