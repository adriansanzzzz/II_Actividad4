using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class p4_6_B : MonoBehaviour
{
    public delegate void CollisionHandler();
    public static event CollisionHandler Add5; 
    public static event CollisionHandler Add10; 
    public static event CollisionHandler OnEnd; 
    public static event CollisionHandler Less10; 

    public TMP_Text pointsText;
    private int points = 0;


  
    void Start()
    {
        p4_6_A.Add5 += AddFive;
        p4_6_A.Add10 += AddTen;
        p4_6_A.OnEnd += OnEndstop;
        p4_6_A.OnEnd += LessTen;


    }

    void Update()
    {
    }


    void AddFive()
    {
        points = points + 5;
        pointsText.text = "points: " + points.ToString(); 

    
    }
    void AddTen()
    {
        points = points + 5;
        pointsText.text = "points: " + points.ToString(); 
    
    }
    void LessTen()
    {
        points = points - 10;
        pointsText.text = "points: " + points.ToString(); 
    
    }
    void OnEndstop()
    {
        pointsText.text = "END - points: " + points.ToString(); 

    
    }

    
}
