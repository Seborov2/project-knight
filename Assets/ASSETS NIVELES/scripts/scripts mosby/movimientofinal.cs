using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientofinal : MonoBehaviour
{
      
    private Rigidbody2D rb;
    private Animator anim;
    private Vector2 direccion;
   
    /// ////////////////
   [Header("Estadisticas")]
   public float velocidad = 10;
    public float salto = 5;
    // complemento 
    [Header("Booleanos")]
    public bool puedemover = true;
    public bool ensuelo = true;

    [Header("Colisiones")]
    public Vector2 abajo;
    public float radio;
    public LayerMask piso;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
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

        mejorasalto();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (ensuelo)
            {
                anim.SetBool("saltar",true);
                saltar1();
            }
        }
        if(ensuelo)
        {
            anim.SetBool("caer", false);
        }
    }


    public void FinalizarSalto()
    {
        anim.SetBool("saltar", false);
        anim.SetBool("caer", true);
    }

    private void caminar()
    {
        if (puedemover)
        {
            rb.velocity = new Vector2(direccion.x * velocidad, rb.velocity.y);
            if(direccion != Vector2.zero)
            {
                if (!ensuelo)
                {
                    anim.SetBool("caer", true);
                }
                else
                {
                    anim.SetBool("caminar", true);
                }


                if(direccion.x<0 && transform.localScale.x>0)
                {
                    transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y,transform.localScale.z);
                }
                else if (direccion.x>0 && transform.localScale.x < 0)
                {
                    transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);

                }

            }
            else
            {
                anim.SetBool("caminar", false);
            }


        }


    }
    private void Agarres()
    {
        ensuelo = Physics2D.OverlapCircle((Vector2)transform.position+abajo,radio,piso);
    }
          
    //Saltar

    private void saltar1()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.velocity += Vector2.up * salto;
    }

    private void mejorasalto()
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
