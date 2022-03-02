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
        bool cajaEsVerdadero = caja.GetComponent<CajaScript>().esVerdadero;
        bool esferaEsVerdadero = esfera.GetComponent<EsferaScript>().esVerdadero;
        //  Color c = new Color(Random.value, Random.value, Random.value);
        // capsula.GetComponent<MeshRenderer>().material.color = c;
        if (cajaEsVerdadero || esferaEsVerdadero)
        {
            capsula.GetComponent<MeshRenderer>().material.color = Color.white;
            Debug.Log("Entro");
        }
        else
        {
            capsula.GetComponent<MeshRenderer>().material.color = Color.black;
        }

        esVerdadero = cajaEsVerdadero || esferaEsVerdadero;
    }
}
