using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechangerboss1 : MonoBehaviour
{
    

    private string nivel1boss;

    
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
            SceneManager.LoadScene("nivel 1 boss");
        
    }
}
