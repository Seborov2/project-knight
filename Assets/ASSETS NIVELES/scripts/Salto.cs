using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 direccion;

    [Header("Estadísticas")]
    public float velocidad = 10;
    public float salto = 5;

    [Header("Colisiones")]
    public Vector2 abajo;
    public float radio;
    public LayerMask piso;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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

        mejorar salto();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(ensuelo)
            {
                saltar1();
            }
        }
    }
}

private void caminar()
{
    if(puedemover)
    {
        rb.velocity = new Vector2(direccion.x * velocidad, RenderBuffer.velocity.y);
        if(direccion != Vector2.zero)
        {
            if (direccion.x < 0 && Transform.localScale.x > 0)
            {
                Transform.localScale = new Vector3(-Transform.localScale.x, Transform.localScale.y, Transform.localScale.z);
            }
            if (direccion.x > 0 && Transform.localScale.x < 0)

            { Transform.localScale = new Vector3(Mathf.Abs(Transform.localScale.x), Transform.localScale.z); }

            


            private void (Agarres())
            {
                ensuelo = Physics2S.OverlapCircle((Vector2)Transform.position + abajo, radio, piso);
            }
            private void saltar1()
            {
                rb.velocity = new Vector2(rb.velocity.x, 0);
                rb.velocity += Vector2.up * salto;
            }

            private void mejorar salto()
            {
                if (rb.velocity.y < 0)
                {
                    rb.velocity += Vector2.up * Physics2D.gravity.y * (2.5f - 1) * Time.deltaTime;    
                }
                else if (rb.velocity.y >0 && !Input.GetKey(KeyCode.Space))
                {
                     rb.velocity += Vector2.up * Physics2D.gravoty.y * (2.0f - 1) * Time.deltaTime;
                 }
        
             }
            }
        }
    
}