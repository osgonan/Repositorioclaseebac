using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosdeCiclosyarreglos : MonoBehaviour
{

    int[] enteros1, enteros2;
    string[] palabras;

    int[,] arreglosBidimencionales;
    int[] arregloUnidimencional;
    // Start is called before the first frame update

    private void Awake()
    {
        enteros1 = new int[10]; 
        enteros2 = new int[10];
        arreglosBidimencionales = new int[2,3] { {5,6,2 },{1,21,3 } };
        arregloUnidimencional = new int[3] { 3, 2,1 };

        palabras = new string[] { "Hola ","Mi ","Nombre","es", "Oscar ", "Mucho ","gusto"}; 
    }
    void Start()
    {
        int[] enteros3= new int[10];
        string oracion="";
        int[] resultadoArreglos= new int[2];
        for (int i = 0; i < 10; i++) {
            enteros1[i] = Random.Range(0, 10);
            enteros2[i] = Random.Range(0, 10);
            enteros3[i] = enteros1[i] + enteros2[i];
        }


        //IMPRESION enteros
        string SEntero1="", SEntero2="", SEntero3="";

        foreach (int palabra in enteros1)
        {
            SEntero1+=palabra+" ";
        }
        foreach (int palabra in enteros2)
        {
            SEntero2 += palabra + " ";
        }
        foreach (int palabra in enteros3)
        {
            SEntero3 += palabra + " ";
        }

        Debug.Log(SEntero1);
        Debug.Log(SEntero2);
        Debug.Log(SEntero3);


        foreach (string palabra in palabras)
        {
            oracion += palabra;
        }

        Debug.Log(oracion);


        for (int i = 0; i < arreglosBidimencionales.GetLength(0); i++)
        {
            int resultado = 0;
            for (int j = 0; j < arreglosBidimencionales.GetLength(1); j++) {
                resultado += (arreglosBidimencionales[i,j]* arregloUnidimencional[j]);
            }
            resultadoArreglos[i] = resultado;
        }

        string SarreglosBidimencionales = "";

        foreach (int resultado in resultadoArreglos) {
            SarreglosBidimencionales += resultado + " ";
        }

        Debug.Log("Resultado es "+SarreglosBidimencionales);




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
