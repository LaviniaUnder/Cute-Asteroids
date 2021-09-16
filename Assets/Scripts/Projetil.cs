using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    public float projetspedd = 5f;
    public Rigidbody2D projetil;

    
    void Start()
    {
        Destroy(gameObject, 2f);
        projetil = gameObject.GetComponent<Rigidbody2D>();
        projetil.velocity = transform.up * projetspedd;
    }

    
    void Update()
    {
        
    }
}
