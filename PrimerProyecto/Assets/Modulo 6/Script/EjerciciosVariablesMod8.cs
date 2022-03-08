using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    public int entero;
    public float flotante;
    public float flotante2,flotante3;
    public string caracter,nombre;

    public int enteroOperacion;
    public string caracterFlotante, nombrePrimero,  apellidoPaterno, apellidoMaterno;
    public string[] listaNombre;
    public string mil1 = "1001", mil2 = "1002";
    public string oracion,segundaoracion;

    private void Awake()
    {
        nombre = "Oscar Eduardo Gonzalez Anaya";
        oracion = "Hola mundo";
        segundaoracion = "adios mundo";
    }
    // Start is called before the first frame update
    void Start()
    {
        


        int valorEnteroMil1,valorEnteroMil2;
        string oracionCortada= segundaoracion.Substring(4);
 
        if (!int.TryParse(mil1, out valorEnteroMil1) || !int.TryParse(mil2, out valorEnteroMil2))
        {
            Debug.Log("parseo de valores de miles no valido");
        }
        else {
            Debug.Log(valorEnteroMil1 + valorEnteroMil2);
        }


        enteroOperacion = (int)(flotante2 * flotante3);



        caracterFlotante = string.Format("{0:#,###.##}", flotante);
        Debug.Log(caracterFlotante);

        nombrePrimero = nombre.Substring(0, 13);
        apellidoPaterno= nombre.Substring(14, 8);
        apellidoMaterno = nombre.Substring(23, 5);

        listaNombre = nombre.Split(' ');

        for (int i = 0; i < oracion.Length; i++) {
            if (i % 2 == 0) {
                Debug.Log(oracion[i]);
            }
        }
 

        Debug.Log(oracionCortada);
        
    }

    // Update is called once per frame
    void Update()
    {
        entero += 1;
    }

    void FixedUpdate()
    {

        flotante *= 2;
        string paroimpar;
        if (entero % 2 == 0)
        {
            paroimpar = "par";
        }
        else
        {
            paroimpar = "impar";
           
        }

        switch (paroimpar)
        {
            case "par":
                this.GetComponent<MeshRenderer>().material.color = Color.black;
                break;
            case "impar":
                this.GetComponent<MeshRenderer>().material.color = Color.white;
                break;

        }

    }


}
