using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EjerciciosEstructuras : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
           List<int> listaDesarreglada = listaNumeroAleatorios(10, 1, 5);
            Debug.Log("Lista Desarreglada");
           foreach (int i in listaDesarreglada) {
               Debug.Log(i);

           }
  
           List<int> listaArreglada = ordenarListas(listaDesarreglada);
        Debug.Log("Lista Ordenada");

        foreach (int i in listaArreglada)
           {
               Debug.Log(i);

           }
           HashSet<int> listaNumerosSinRepetir = listaSinRepetidos(listaArreglada);
        Debug.Log("Lista Sin Repetir");

        foreach (int i in listaNumerosSinRepetir) {
               Debug.Log(i);
           }
             

        Stack<string> pilaString = new Stack<string>();
 
        pilaString.Push("Primero");
        pilaString.Push("Segundo");
        pilaString.Push("Tercero");
        pilaString.Push("Cuarto");
        pilaString.Push("Quinto");
        pilaString.Push("Sexto");

        imprimirPilaYCola(pilaString);
    }
    public List<int> listaNumeroAleatorios(int tamanio, int minimo, int maximo) {

        List<int> lista = new List<int>();
        for (int i = 0; i < tamanio; i++) {
            lista.Add(Random.Range(minimo, maximo));
        }
        return lista;
    }

    public List<int> ordenarListas(List<int> lista)
    {
        return lista.OrderByDescending(a => a).ToList(); 
    }

    static HashSet<T> listaSinRepetidos<T>(List<T> lista)
    {
        return new HashSet<T>(lista);
    }

    public void imprimirPilaYCola(Stack<string> pila) {

        Queue<string> fila = new Queue<string>();
        Debug.Log("Pila");

        while (pila.Count > 0) {
            Debug.Log(pila.Peek()); 
            fila.Enqueue(pila.Pop());

        }

        Debug.Log("Fila");

        while (fila.Count>0)
        {
            Debug.Log(fila.Dequeue());
           
        }
 

    }

}
