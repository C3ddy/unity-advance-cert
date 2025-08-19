using System;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    [SerializeField] private float health = 100.0f;

    
    private float healthMax;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthMax = health;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log(health);
    }

    public float GetHealth()
    {
        return health;
    }

    public void AddHealth(float newHealth)
    {
        health += newHealth;
        if (health > healthMax)
        {
            health = healthMax;
        }
        Debug.Log("New health added " + health);
    }
}
