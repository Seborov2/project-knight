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


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        


        if (other.tag == "Player")
        {
            other.gameObject.transform.position = Respawn.transform.position;
            vidacaballero--;
            Debug.Log(vidacaballero);

        }
        if (vidacaballero == 0)
        {
            SceneManager.LoadScene("game over");
        }
    }
}
