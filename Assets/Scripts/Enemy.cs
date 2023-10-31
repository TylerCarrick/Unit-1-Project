using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject player;
    SpriteRenderer sr;
    Helper helper;
    public Transform respawnPoint;


    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        helper = gameObject.AddComponent<Helper>();
    }


    void Update()
    {
        bool hit;


        hit = helper.ExtendedRayCollisionCheck(0, 0.1f);



        Vector3 scale = transform.localScale;

        if (player.transform.position.x > transform.position.x)
        {
            sr.flipX = true;
            transform.position = new Vector2(transform.position.x + (3 * Time.deltaTime), transform.position.y);
        }

        if (player.transform.position.x < transform.position.x)
        {
            sr.flipX = false;
            transform.position = new Vector2(transform.position.x + (-3 * Time.deltaTime), transform.position.y);
        }










    }
}
   
