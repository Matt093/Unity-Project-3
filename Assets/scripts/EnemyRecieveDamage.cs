using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyRecieveDamage : MonoBehaviour
{
    public float health;
    public float maxhealth;

    public GameObject healthbar;
    public Slider healthbarslider;

    private void Start()
    {
        health = maxhealth;
    }

    public void DealDamge(float damge)
    {
        healthbar.SetActive(true);
        health -= damge;
        Checkdeath();
        healthbarslider.value = CalculateHealth();
    }

    private void CheckOverheal()
    {
        health = maxhealth;

    }

    private void Checkdeath()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void HealCharacter(float heal)
    {
        health += heal;
        CheckOverheal();
        healthbarslider.value = CalculateHealth();
    }
    private float CalculateHealth()
    {
        return (health / maxhealth);
    }
}
