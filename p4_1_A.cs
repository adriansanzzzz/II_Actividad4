using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto_A : MonoBehaviour
{
    public delegate void CollisionHandler();
    public static event CollisionHandler OnCubeCollision; // Event to handle cube-cylinder collision
    public string cubeTag = "red_cube"; 

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(cubeTag))
        {
            Debug.Log("colision --> notifico");
            OnCubeCollision(); // Trigger the event
        }
            
    }

}
