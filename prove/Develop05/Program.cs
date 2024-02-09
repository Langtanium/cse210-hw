/*
Added code to prevent the user from getting points if they select the
Record Event option and choose a goal that has already been completed.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager eternalQuest = new GoalManager();
        eternalQuest.Start();
    }
}