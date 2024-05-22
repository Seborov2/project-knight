using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class los_puntos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        puntos.score++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
