using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p4_6_A : MonoBehaviour // SCRIPT PARA bola
{
    public delegate void CollisionHandler();
    public static event CollisionHandler Add5;
    public static event CollisionHandler Add10;
    public static event CollisionHandler OnEnd;
    public static event CollisionHandler Less10;

    public string fiveTag = "5points";
    public string tenTag = "10points";
    public string malTag = "mal";
    public string finalTag = "end";

    private bool isMoving = false;
    private float moveSpeed = 20.0f; // Velocidad de movimiento 
    private GameObject cubo; // Variable para almacenar el objeto "end"

    void Start()
    {
        cubo = GameObject.FindWithTag(finalTag);
    }

     void Update()
    {
       // Captura la entrada del teclado en los ejes horizontal y vertical
        float horizontalInput = Input.GetAxis("HCubo");
        float verticalInput = Input.GetAxis("VCubo");

            // Calcula el vector de movimiento basado en la entrada del teclado
        Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput).normalized;
        GetComponent<Rigidbody>().velocity = moveDirection * moveSpeed;

    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(fiveTag))
        {
            Add5();
        }
        if (collision.gameObject.CompareTag(tenTag))
        {
            Add10();
        }
        if (collision.gameObject.CompareTag(tenTag))
        {
            Less10();
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity *= 0.9f; 
        }
        if (collision.gameObject.CompareTag(finalTag))
        {
            OnEnd();
        }
    }
}
