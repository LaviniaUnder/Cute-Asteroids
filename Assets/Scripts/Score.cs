using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Score : MonoBehaviour
{
    public TextMesh score;
    public int points = 5;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Addpoints()
    {

        int soma = points + Int32.Parse(score.text);
        score.text = soma.ToString();
    }
}
