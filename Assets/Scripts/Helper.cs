using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helper : MonoBehaviour
{
    LayerMask groundLayerMask;


    void Start()
    {
        groundLayerMask = LayerMask.GetMask("Ground");

    }






    public void FlipObject(bool flip)
    {
        
        SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>();

        if (flip == true)
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
        }
    }


    public bool ExtendedRayCollisionCheck(float xoffs, float yoffs)
    {
        float rayLength = 0.7f;
        bool hitSomething = false;


        Vector3 offset = new Vector3(xoffs, yoffs, 0);


        RaycastHit2D hit;


        hit = Physics2D.Raycast(transform.position + offset, -Vector2.up, rayLength, groundLayerMask);

        Color hitColor = Color.white;


        if (hit.collider != null)
        {
            print("Player has collided with Ground layer");
            hitColor = Color.green;
            hitSomething = true;
        }

        Debug.DrawRay(transform.position + offset, -Vector2.up * rayLength, hitColor);

        return hitSomething;

    }




}






