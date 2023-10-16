using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class p4_5_B : MonoBehaviour
{
    public delegate void CollisionHandler();
    public static event CollisionHandler AddPoint1; 
    public static event CollisionHandler AddPoint2; 
    public TMP_Text pointsText;
 

    private int points = 0;
  
    void Start()
    {
        p4_5_A.AddPoint1 += Add5;
        p4_5_A.AddPoint2 += Add10;

    }

    void Update()
    {
    }


    void Add5()
    {
        points = points + 5;
        pointsText.text = "points: " + points.ToString(); // Concatenar "points: " con el valor de 'points'



    
    }

    void Add10()
    {
        points = points + 10;
        pointsText.text = "points: " + points.ToString(); // Concatenar "points: " con el valor de 'points'



    
    }

    
}
