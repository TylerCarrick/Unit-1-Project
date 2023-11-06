using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public Player player;
    public int damage = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2d(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //player.TakeDamage(damage);

        }


    }


}
