using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody2D RigidPlayer;
    public float speed, speedrotate, maxspeed, downspeed;
    private bool ismoving = false;
    public GameObject Projetil;
    public GameObject animation;

    public Restart control;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        ismoving = false;

        if(Input.GetKey(KeyCode.UpArrow))
        {
            RigidPlayer.AddForce(transform.up * speed);
            ismoving = true;
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            RigidPlayer.AddForce(transform.up * speed * -1);
            ismoving = true;
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            RigidPlayer.rotation -= speedrotate * Time.deltaTime;
            
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            RigidPlayer.rotation += speedrotate * Time.deltaTime;
        
        }

        if(RigidPlayer.velocity.magnitude > maxspeed)
        {
            RigidPlayer.velocity = Vector2.ClampMagnitude(RigidPlayer.velocity, maxspeed);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Projetil, transform.position, transform.rotation);
        }

    }
    void OnTriggerEnter2D(Collider2D outro)
    {
        Instantiate(animation, transform.position, transform.rotation);
        control.restartgame();
        Destroy(gameObject);
    }
}
