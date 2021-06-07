using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour
{
    public int damg = -20;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<HealthSystem>().TakeDmg(damg);
        Debug.Log("Damage Taken");
    }
}
