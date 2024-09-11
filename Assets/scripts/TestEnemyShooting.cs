using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemyShooting : MonoBehaviour
{
    public GameObject projectile;
    private GameObject player;
    public float minDamge;
    public float maxDamge;
    public float projectileForce;
    public float cooldown;

    void Start()
    {
        StartCoroutine(ShootPlayer());
        player = FindObjectOfType<playerMovement>().gameObject;
    }

    IEnumerator ShootPlayer()
    {
        yield return new WaitForSeconds(cooldown);
        if(player != null)
        {
            GameObject spell = Instantiate(projectile, transform.position, Quaternion.identity);
            Debug.Log(player.transform.position);
            Vector2 myPos = transform.position;
            Vector2 targetPos = player.transform.position;
            Vector2 direction = (targetPos - myPos).normalized;
            spell.GetComponent<Rigidbody2D>().velocity = direction * projectileForce;
            spell.GetComponent<TestEnemyProjectile>().damge = Random.Range(minDamge, maxDamge);
            StartCoroutine(ShootPlayer());
        }
    }

  
}
