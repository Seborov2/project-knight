using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Vida : MonoBehaviour
{
    public GameObject player;
    public GameObject Respawn;
    public static int vidacaballero = 3;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Respawn = GameObject.FindGameObjectWithTag("Respawn");//Encontrar al jugador con una etiqueta.
        Debug.Log(vidacaballero);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);



        if (collision.tag == "player")
        {
            collision.gameObject.transform.position = Respawn.transform.position;
            vidacaballero--;
            Debug.Log(vidacaballero);

        }
        if (vidacaballero == 0)
        {
            SceneManager.LoadScene("gameover");
        }
    }
   
}
