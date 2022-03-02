using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsferaScript : MonoBehaviour
{
    public GameObject esfera;
    public bool esVerdadero;

    // Update is called once per frame
    void Update()
    {
       // Color c = new Color(Random.value, Random.value, Random.value);
       // esfera.GetComponent<MeshRenderer>().material.color = c;
    }

    private void FixedUpdate()
    {
        if (esVerdadero)
        {
            esfera.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
            esfera.GetComponent<MeshRenderer>().material.color = Color.black;
        }
        esVerdadero = !esVerdadero;
    }
}
