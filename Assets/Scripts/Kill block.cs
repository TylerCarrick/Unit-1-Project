using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killblock : MonoBehaviour
{
    public Transform spawnPoint;
    public Transform respawnPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            //Destroy(other.gameObject);

            other.gameObject.GetComponent<Transform>().position = respawnPoint.transform.position;

        }
        if (other.gameObject.name == "Enemy")
        {
            //Destroy(other.gameObject);

            other.gameObject.GetComponent<Transform>().position = spawnPoint.transform.position;

        }
    }

}

