using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaScript : MonoBehaviour
{
    public GameObject caja;
    void Awake()
    {

        Color c = new Color(Random.value, Random.value, Random.value);
        caja.GetComponent<MeshRenderer>().material.color = c;
        
    }
 

    // Update is called once per frame
    void Update()
    {
        
    }
}
