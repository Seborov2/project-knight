using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechangernivel1 : MonoBehaviour
{
    

    private string nivel_1;
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
            SceneManager.LoadScene("nivel 1");
        
    }
}
