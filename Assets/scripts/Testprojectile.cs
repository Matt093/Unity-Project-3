using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testprojectile : MonoBehaviour
{
    public float damge;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.tag != "Player" )
        {
           if(collision.GetComponent<EnemyRecieveDamage>() != null)
            {
                collision.GetComponent<EnemyRecieveDamage>().DealDamge(damge);

            }
            
            
            Destroy(gameObject);
        }
    }
}
