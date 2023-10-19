using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto_B : MonoBehaviour // SCRIPT PARA ESFERA
{
    public delegate void CollisionHandler();
    public static event CollisionHandler OnCubeCollision; 
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

        Objeto_A.OnCubeCollision += HandleCubeCollision;
    }

    void Update(){
        if(moveEsferas){
        Vector3 cylinderPosition = cilindro.transform.position;
        float velocidadMovimiento = 10.0f;

        foreach (var esfera in esferasType2)
        {
            Vector3 direction = cylinderPosition - esfera.transform.position;
            esfera.transform.Translate(direction.normalized * velocidadMovimiento * Time.deltaTime);
        }

        }

    }

    void HandleCubeCollision()
    {
        moveEsferas=true;

        foreach (var esfera in esferasType1)
        {
            Renderer renderer = esfera.GetComponent<Renderer>();
            renderer.material.color = Color.green;
        }

    }
}
