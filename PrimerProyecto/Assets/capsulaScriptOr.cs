using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsulaScriptOr : MonoBehaviour
{
    public GameObject capsula;
    public GameObject caja;
    public GameObject esfera;
    public bool esVerdadero;

    void FixedUpdate()
    {
        //  Color c = new Color(Random.value, Random.value, Random.value);
        // capsula.GetComponent<MeshRenderer>().material.color = c;
        bool cajaEsVerdadero = caja.GetComponent<CajaScript>().esVerdadero;
        bool esferaEsVerdadero = esfera.GetComponent<EsferaScript>().esVerdadero;

        if (cajaEsVerdadero || esferaEsVerdadero)
        {
            capsula.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
            capsula.GetComponent<MeshRenderer>().material.color = Color.black;
        }

        esVerdadero = cajaEsVerdadero || esferaEsVerdadero;
    }
}
