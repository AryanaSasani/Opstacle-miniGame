using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
   [SerializeField] float speed=5f;

    // Start is called before the first frame update
    void Start()
    {
      Introduction();
    }

    // Update is called once per frame
    void Update()
    {
      MovePlayer();
    }


   void MovePlayer()
   {
      float xValue=Input.GetAxis("Horizontal")*Time.deltaTime*speed;
      float zValue=Input.GetAxis("Vertical")*Time.deltaTime*speed;
      transform.Translate(xValue,0f,zValue);  
   }
   void Introduction()
   {
      Debug.Log("Use << W A D S >>  keys to move ! \n dont touch the walls !");
   }
}
