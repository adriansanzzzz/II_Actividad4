using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p4_5_A : MonoBehaviour // SCRIPT PARA CUBO
{
    public delegate void CollisionHandler();
    public static event CollisionHandler AddPoint1; 
    public static event CollisionHandler AddPoint2; 


    public string esfera1Tag = "first_blue_esfera";
    public string esfera2Tag = "blue_esfera";

    public int points = 0;


  
  
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(esfera1Tag))
        {
            AddPoint1();
            Destroy(collision.gameObject);
            

        }
         if (collision.gameObject.CompareTag(esfera2Tag))
        {
            AddPoint2();
            Destroy(collision.gameObject);
        

        }
        
            
    }
}
