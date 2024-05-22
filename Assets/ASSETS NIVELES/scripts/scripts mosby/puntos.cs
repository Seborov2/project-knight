using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntos : MonoBehaviour
{
    // Start is called before the first frame update
    public static int score = 0;
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = score.ToString();
    }
}
