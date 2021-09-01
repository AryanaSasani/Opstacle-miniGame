using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int hitTimes=0;
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag!="Hit")
        { 
            hitTimes++;
            Debug.Log("You'v Bumbed into a thing this many times : "+hitTimes);
        }
    }
}
