using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechangercarnaval : MonoBehaviour
{
    

    private string carnaval;
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
            SceneManager.LoadScene("carnaval");
        
    }
}
