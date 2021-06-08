using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public float maxHealth = 100f;
    private float minHealth = 0;

    public float health = 100f;
    
    void Start()
    {
        health = maxHealth;
    }

    
    void Update()
    {
        if (health <= minHealth)
        {
            OnDeath();
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            OnDeath();
        }
    }

    public void TakeDmg(int dmg)
    {
        health = health - -dmg;

        Debug.Log("Current Health" + health);
    }

    public void OnDeath()
    {
        GameObject.Destroy(this.gameObject);
    }
}
