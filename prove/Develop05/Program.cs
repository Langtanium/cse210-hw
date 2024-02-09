/*
Added code to prevent the user from getting points if they select the
Record Event option and choose a goal that has already been completed.

public abstrct void RecordEvent(); has been changed to public abstrct
int RecordEvent(); to be able to return the amount of points associated
with a goal.
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