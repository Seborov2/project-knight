using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 direccion;

    [Header("Estadísticas")]
    public float velocidad = 10;
    public float salto = 5;

    [Header("Colisiones")]
    public Vector2 abajo;
    public float radio;
    public LayerMask suelo;

    [Header("booleanos")]
    //public Collider2D ensuelo;
    public bool puedemover = true;
    public bool ensuelo = true;



    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        movimiento();
        Agarres();
    }

    private void movimiento()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        direccion = new Vector2(x, y);
        caminar();

        mejorarsalto();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (ensuelo)
            {
                saltar1();
            }
        }
    }
    private void Agarres()
    {
        ensuelo = Physics2D.OverlapCircle((Vector2)transform.position + abajo, radio, suelo);
    }
    private void saltar1()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.velocity += Vector2.up * salto;
    }
    private void caminar()
    {
        if (puedemover)
        {
            rb.velocity = new Vector2(direccion.x * velocidad, rb.velocity.y);
            if (direccion != Vector2.zero)
            {
                if (direccion.x < 0 && transform.localScale.x > 0)
                {
                    transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
                }
                if (direccion.x > 0 && transform.localScale.x < 0)

                {
                    transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.z);
                }

            }
        }
    }

    private void mejorarsalto()
    {
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (2.5f - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.Space))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (2.0f - 1) * Time.deltaTime;
        }
    }

}
