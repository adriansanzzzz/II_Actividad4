using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p4_3_A : MonoBehaviour // SCRIPT PARA CUBO
{
    public delegate void CollisionHandler();
    public static event CollisionHandler OnNear; 

    public string esfera1Tag = "first_blue_esfera";
    public string esfera2Tag = "blue_esfera";
    public string cilindroTag = "green_cil";

    void Update()
    {
        GameObject cilindro = GameObject.FindWithTag(cilindroTag); // Obtener el cilindro por su etiqueta
        float distancia = Vector3.Distance(transform.position, cilindro.transform.position);

        // Definir la distancia de aproximación deseada
        float distanciaDeAproximacion = 5.0f;

        if (distancia <= distanciaDeAproximacion)
        {
            OnNear(); 
        }
    }
}
