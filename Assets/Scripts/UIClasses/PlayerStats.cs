using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public float StartHealth;
    public float Health;

    private void Start()
    {
        Health = StartHealth;
    }

    public void TakeDamage(float Damage)
    {
        if(Health > 0)
        {
            Health -= Damage;
        }
        if(Health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }

}
