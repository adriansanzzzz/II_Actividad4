using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p4_3_B : MonoBehaviour
{
    public delegate void CollisionHandler();
    public static event CollisionHandler OnNear; 
    public string esfera1Tag = "first_blue_esfera";
    public string esfera2Tag = "blue_esfera";
    public GameObject target;


    private GameObject[] esferasType1;
    private GameObject[] esferasType2;
    private GameObject cilindro;
    private bool direction_to_esferas = false; // Variable para controlar el movimiento de las esferas


    void Start()
    {
        esferasType1 = GameObject.FindGameObjectsWithTag(esfera1Tag);
        esferasType2 = GameObject.FindGameObjectsWithTag(esfera2Tag);
        cilindro = GameObject.FindWithTag("green_cil");

        p4_3_A.OnNear += ChageColor;

    }

    void Update(){
        if(direction_to_esferas){
        
         foreach (var esfera in esferasType2)
        {
            esfera.transform.LookAt(target.transform);
            Debug.DrawRay(esfera.transform.position, esfera.transform.forward * 10, Color.green);

        }
        
        }
    }
    

    void ChageColor()
    {
        Debug.Log("colision");
        direction_to_esferas=true;

          foreach (var esfera in esferasType1)
        {
            //grupo 1 color
            Renderer renderer = esfera.GetComponent<Renderer>();
            renderer.material.color = Color.green;
        }

         foreach (var esfera in esferasType1)
        {
            Rigidbody rigidbody = esfera.GetComponent<Rigidbody>();
            rigidbody.AddForce(Vector3.up * 5.0f,ForceMode.Impulse);
        }

    
    }

    
}
