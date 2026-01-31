using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_revive : MonoBehaviour
{
    public int fuhuocount = 0;
    public void AddReviveCount(int amount =1)
    {
        fuhuocount += amount;
        Debug.Log("获得复活次数，现在是:"+ fuhuocount);
    }
    public bool TryRevive()
    {
        if (fuhuocount  > 0)
        {
            fuhuocount--;
            Debug.Log("使用复活！剩余：" + fuhuocount);
            return true;
        }
        return false;
    }
    
}
