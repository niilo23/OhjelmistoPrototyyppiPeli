using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    [SerializeField]
    Transform player;
    
    [SerializeField]
    float agroRange;

    [SerializeField]
    float moveSpeed;

    Rigidbody2D rb2d;
   
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //How much distance to player
        float distToPlayer = Vector2.Distance(transform.position, player.position);
        
        if(distToPlayer < agroRange)
        {
            //player chase
            ChasePlayer();
            
        }
        else
        {
            //stop player chase
            StopChasingPlayer();
        }
    }

    void ChasePlayer()
    {
        if(transform.position.x < player.position.x)
        {
            //enemy to the left of player, so move right
            rb2d.velocity = new Vector2(moveSpeed, 0);
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (transform.position.x > player.position.x)
        {
            //enemy to the right of player, so move left
            rb2d.velocity = new Vector2(-moveSpeed, 0);
           
            GetComponent<SpriteRenderer>().flipX = true;
        }
    }

    void StopChasingPlayer()
    {
        rb2d.velocity = Vector2.zero;
    }
}
