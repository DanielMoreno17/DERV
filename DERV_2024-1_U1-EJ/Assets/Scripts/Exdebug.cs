using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExDebug : MonoBehaviour
{

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Se presiono la tecla W");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Se presiono la tecla S");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Se presiono la tecla D");
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Se presiono la tecla A");
        }
    }
}
