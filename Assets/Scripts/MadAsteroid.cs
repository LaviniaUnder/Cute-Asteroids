using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MadAsteroid : MonoBehaviour
{
    public Rigidbody2D RigidEmoji;
    public float constantspeed;
    private AudioSource explosionsound;
    private Score pluspoint;
    public GameObject animation;
    void Start()
    {
        explosionsound = GameObject.Find("Explosionsound").GetComponent<AudioSource>();
        pluspoint = GameObject.Find("Points").GetComponent<Score>();
        RigidEmoji.velocity = Random.insideUnitCircle * constantspeed;
    }

    
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D outro)
    {
        explosionsound.Play();
        pluspoint.Addpoints();
        Instantiate(animation, transform.position, transform.rotation);
        Destroy(outro.gameObject);
        Destroy(gameObject);
    }
}
