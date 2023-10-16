using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p4_2_A : MonoBehaviour //SCRIPT PARA CUBO
{
    public delegate void CollisionHandler();
    public static event CollisionHandler OnEsfera1Collision; // Event to handle cube-cylinder collision
    public static event CollisionHandler OnEsfera2Collision; // Event to handle cube-cylinder collision

    public string esfera1Tag = "first_blue_esfera";
    public string esfera2Tag = "blue_esfera";
    public string cilindroTag = "green_cil";


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(esfera1Tag))
        {
            OnEsfera2Collision(); 
        }else if(collision.gameObject.CompareTag(esfera2Tag) ||collision.gameObject.CompareTag(cilindroTag) ){
            OnEsfera1Collision(); 
        }
    }

}
