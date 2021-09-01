using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer meshrenderer;
    Rigidbody rigidbody;
      float timeToWait=5f;
    // Start is called before the first frame update
    void Start()
    {
        meshrenderer = GetComponent<MeshRenderer>();
        rigidbody=GetComponent<Rigidbody>();
                
        meshrenderer.enabled=false;
        rigidbody.useGravity=false;
    }

    // Update is called once per frame
    void Update()
    {
      if(Time.time>timeToWait)
      {
        meshrenderer.enabled=true;
        rigidbody.useGravity=true;
      }
        
    }
}
