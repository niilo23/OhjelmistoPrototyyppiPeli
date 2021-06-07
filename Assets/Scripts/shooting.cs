using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Transform player;
   public Rigidbody2D bullet;
   public Transform firePoint;
    public float bulletSpeed = 50;

    Vector2 lookDirection;
    float lookAngle;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody2D bulletClone = Instantiate(bullet, firePoint.position, Quaternion.Euler(player.rotation.y, 0, 0)) as Rigidbody2D;

            bulletClone.velocity = new Vector3(bulletSpeed, 0, 0);
            
        }
    }
}
