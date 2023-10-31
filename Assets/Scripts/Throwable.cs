using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwable : MonoBehaviour
{
    void Start()
    {

    }

    private Vector3 refPos;
    private GameObject target;
    private bool sticked = false;
    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        target = collision.gameObject;
        Vector3 refPos = contact.point - target.transform.position;
        sticked = true;


    }

    void Update()
    {
    if (sticked)
            transform.position = target.transform.position + refPos;

    }

  //  private void OnTriggerEnter2D(Collider2D other)
    
      //  if (other.gameObject.name == "Enemy")
        
          //  Destroy(other.gameObject);



}
    

   

