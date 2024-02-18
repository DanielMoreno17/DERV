using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExOtherGetKey : MonoBehaviour
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

        if (Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("Se presiono la tecla D");
        }

        if(Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("Se presiono la tecla A");
        }
    }
}
