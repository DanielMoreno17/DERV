using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterials : MonoBehaviour
{
    public Renderer rend;
    public Material color1;
    public Material color2;

    [SerializeField] private Material color3;
    [SerializeField] private Material color4;


    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rend.material = color1;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            rend.material = color2;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rend.material = color3;
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            rend.material = color4;
        }
    }
}
