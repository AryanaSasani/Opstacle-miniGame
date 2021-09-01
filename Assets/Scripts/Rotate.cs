using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float xAngle=0;
    [SerializeField] float yAngle=0;
    [SerializeField] float zAngle=0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yAngle=1;
        transform.Rotate(xAngle,yAngle,zAngle);
    }
}
