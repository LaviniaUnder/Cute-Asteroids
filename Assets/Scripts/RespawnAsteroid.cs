using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnAsteroid : MonoBehaviour
{
    public int NumberAsteroid = 3;
    public GameObject Asteroid;
    public float cooldown = 3f;
    private float LastRespawn = 0;


    void Start()
    {
        for (int i = 0; i < NumberAsteroid; i++)
            {
                float x = Random.Range(-9f,9f);
                float y = Random.Range(-5f,5f);
                Vector3 randomposition = new Vector3(x,y,0);
                Instantiate(Asteroid, randomposition, Quaternion.identity);
            }
    }

    
    void Update()
    {
        if(LastRespawn + cooldown < Time.time)
        {
            LastRespawn = Time.time;
            for (int i = 0; i < NumberAsteroid; i++)
            {
                float x = Random.Range(-9f,9f);
                float y = Random.Range(-5f,5f);
                Vector3 randomposition = new Vector3(x,y,0);
                Instantiate(Asteroid, randomposition, Quaternion.identity);
            }
        }
    }
}
