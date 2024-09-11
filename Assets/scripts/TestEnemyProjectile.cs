using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemyProjectile : MonoBehaviour
{
    public float damge;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name != "Enemy bug")
        {
            if(collision.name == "bug")
            {
                PlayerStats.playerStats.DealDamge(damge);
            }
     
            Destroy(gameObject);
        }
    }
}
