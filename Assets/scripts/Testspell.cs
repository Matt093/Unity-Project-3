﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testspell : MonoBehaviour
{
    public GameObject projectile;
    public float minDamge;
    public float maxDamge;
    public float projectileForce;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            GameObject spell = Instantiate(projectile, transform.position, Quaternion.identity);
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 myPos = transform.position;
            Vector2 direction = (mousePos - myPos).normalized;
            spell.GetComponent<Rigidbody2D>().velocity = direction * projectileForce;
            spell.GetComponent<Testprojectile>().damge = Random.Range(minDamge, maxDamge);

        }
    }



}
