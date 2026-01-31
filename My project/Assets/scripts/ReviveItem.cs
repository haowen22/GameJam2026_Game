using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReviveItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("碰到了：" + other.name);
        if (other.CompareTag("Player"))
        {
            Debug.Log("是 Player，准备销毁道具");
            Player_revive revive = other.GetComponent<Player_revive>();
            if (revive != null)
            {
                revive.AddReviveCount(1);
                Destroy(gameObject); 
            }
        }
    }
}
