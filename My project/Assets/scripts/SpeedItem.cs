using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedItem : MonoBehaviour
{
    public float speedMultiplier = 1.5f;
    public float duration = 3f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerControl player = other.GetComponent<PlayerControl>();
            if (player != null)
            {
                player.BoostSpeed(speedMultiplier, duration);
                Destroy(gameObject);
            }
        }
    }
}
