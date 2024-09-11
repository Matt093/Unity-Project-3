using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerStats : MonoBehaviour
{
    public static PlayerStats playerStats;

    public GameObject player;
    public Text healthtext;
    public Slider healthslider;


    public float health;
    public float maxhealth;

    private void Awake()
    {
       if(playerStats != null)
        {
            Destroy(playerStats);
        }
        else
        {
            playerStats = this;
        }
        DontDestroyOnLoad(this);
    }


    private void Start()
    {
        health = maxhealth;
        sethealthUI();

    }
    private void sethealthUI()
    {
        healthslider.value = CalculateHealth();
        healthtext.text = Mathf.Ceil(health).ToString() + "/ " + Mathf.Ceil(maxhealth).ToString();
    }

    public void DealDamge(float damge)
    {
        health -= damge;
        Checkdeath();
        sethealthUI();
    }

    public void HealCharacter(float heal)
    {
        health += heal;
        CheckOverheal();
        sethealthUI();
    }
    private void CheckOverheal()
    {
        health = maxhealth;
    }

    private void Checkdeath()
    {
        if (health <= 0)
        {
            Destroy(player);
            health = 0;
        }
    }

    float CalculateHealth()
    {
        return health / maxhealth;
    }
}
