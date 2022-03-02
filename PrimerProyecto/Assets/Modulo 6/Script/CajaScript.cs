using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaScript : MonoBehaviour
{
    public GameObject caja;
    public bool esVerdadero;
    void Awake()
    {
        esVerdadero = true;
        //Color c = new Color(Random.value, Random.value, Random.value);
        //caja.GetComponent<MeshRenderer>().material.color = c;

    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (esVerdadero)
        {
            caja.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else {
            caja.GetComponent<MeshRenderer>().material.color = Color.black;
        }
        esVerdadero = !esVerdadero;
    }
}
