using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamageEnemy : MonoBehaviour
{
   
    public int bulletDamageEnemy;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Player>().damagePlayer(bulletDamageEnemy);
            Destroy(gameObject);
        }

        
    }

    

}
