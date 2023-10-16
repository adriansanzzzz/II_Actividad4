using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p4_4_B : MonoBehaviour
{
    public delegate void CollisionHandler();
    public static event CollisionHandler AddPoint1; 
    public static event CollisionHandler AddPoint2;  

    private int points = 0;
  
    void Start()
    {
        p4_4_A.AddPoint1 += Add5;
        p4_4_A.AddPoint2 += Add10;

    }

    void Update()
    {
    }


    void Add5()
    {
        points = points + 5;
        Debug.Log($"Points: {points}");

    
    }

    void Add10()
    {
        points = points + 10;
        Debug.Log($"Points: {points}");

    
    }

    
}
