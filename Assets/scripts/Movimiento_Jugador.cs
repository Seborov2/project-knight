using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Jugador : MonoBehaviour
{
    public float velocidad;
    public Rigidbody2D rb2d;
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
