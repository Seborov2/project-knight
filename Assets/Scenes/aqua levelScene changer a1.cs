using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechangeraqua : MonoBehaviour
{
    

    private string aqua_level;
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
            SceneManager.LoadScene("aqua level");
        
    }
}
