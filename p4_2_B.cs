using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p4_2_B : MonoBehaviour
{
    public delegate void CollisionHandler();
    public static event CollisionHandler OnEsfera1Collision; 
    public static event CollisionHandler OnEsfera2Collision; 
    public string esfera1Tag = "first_blue_esfera";
    public string esfera2Tag = "blue_esfera";

    private GameObject[] esferasType1;
    private GameObject[] esferasType2;
    private GameObject cilindro;
    private bool moveEsferas = false; // Variable para controlar el movimiento de las esferas


    void Start()
    {
        esferasType1 = GameObject.FindGameObjectsWithTag(esfera1Tag);
        esferasType2 = GameObject.FindGameObjectsWithTag(esfera2Tag);
        cilindro = GameObject.FindWithTag("green_cil");

        p4_2_A.OnEsfera1Collision += MoveToCil;
        p4_2_A.OnEsfera2Collision += BiggerSize;

    }

    void Update(){
        if(moveEsferas){
        Vector3 cylinderPosition = cilindro.transform.position;
        float velocidadMovimiento = 5.0f;

        foreach (var esfera in esferasType1)
        {
            Vector3 direction = cylinderPosition - esfera.transform.position;
            esfera.transform.Translate(direction.normalized * velocidadMovimiento * Time.deltaTime);
        }

        }

    }

    void MoveToCil()
    {
        Debug.Log("colision");
        moveEsferas=true;
    }

    void BiggerSize()
    {
        foreach (var esfera in esferasType2)
        {
            // Duplicar el tamaño de la esfera
            esfera.transform.localScale *= 2f;
        }
    }
}
