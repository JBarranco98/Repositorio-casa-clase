using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioAreaRectangulo : MonoBehaviour
{

    // En este ejercicio vamos a calcular el area de un ractangulo dada sus lados

    public float lado1 = 0;
    public float lado2 = 0;
    float resultado;

    // Start is called before the first frame update
    void Start()
    {
        resultado = lado1 * lado2;
        Debug.Log("El area del rectangulo es " + resultado + " metros cuadrados");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
