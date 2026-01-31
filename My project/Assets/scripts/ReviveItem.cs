using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReviveItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Player_revive revive = other.GetComponent<Player_revive>();
            if (revive != null)
            {
                revive.AddReviveCount(1);
                Destroy(gameObject); 
            }
        }
    }
}
