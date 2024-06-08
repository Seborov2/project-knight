using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechangerbosque : MonoBehaviour
{
    

    private string bosque_pre_guardia;
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
            SceneManager.LoadScene("bosque pre guardia");
        
    }
}
