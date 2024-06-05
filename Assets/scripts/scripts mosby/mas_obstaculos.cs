using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mas_obstaculos : MonoBehaviour
{
    public float tmax = 1;
    public float tinicial;
    public  GameObject obst;
    public float altura1, altura2;

    // Start is called before the first frame update
    void Start()
    {
        if(tinicial > tmax)
        {
            GameObject nuevoboost = Instantiate(obst);
            nuevoboost.transform.position = transform.position + new Vector3(0, Random.Range(altura1, altura2), 0);
            tinicial = 0;

        }

        else
        {
            tinicial += Time.deltaTime;
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
