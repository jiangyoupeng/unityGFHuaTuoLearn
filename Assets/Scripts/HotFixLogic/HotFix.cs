using UnityEngine;
using GameHotFix;

public class HotFix
{

    public static void GameEntry()
    {
        Debug.Log("HotFixLogic Init 123");

        HotFixEntry.Start();
    }
}
