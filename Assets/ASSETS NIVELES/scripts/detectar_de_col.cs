using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectar_de_col : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("un objeto con nombre " + collision.gameObject.name + " entró en colision");
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("un objeto con nombre " + collision.gameObject.name + " está en colision");
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("un objeto con nombre " + collision.gameObject.name + " no es está en colision");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
