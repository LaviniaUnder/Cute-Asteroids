using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void restartgame()
    {
        Invoke("delay", 2f);
    }

    public void delay()
    {
        SceneManager.LoadScene(0);
    }
}
