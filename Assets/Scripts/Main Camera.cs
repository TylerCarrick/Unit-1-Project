using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
  
    void Start()
    {
        
    }
    public Transform followTransform;

    void Update()
    {
        this.transform.position = new Vector3(followTransform.position.x + 0.4f, followTransform.position.y + 0.5f, this.transform.position.z);
    }
}
