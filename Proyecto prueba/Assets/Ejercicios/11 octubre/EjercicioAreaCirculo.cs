using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioAreaCirculo : MonoBehaviour
{
    // En este ejercicio vamos a calcular el area de un circulo dado su radio

    public float radioCirculo;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El area del circulo es " + radioCirculo * radioCirculo * Mathf.PI + " centimetros cuadrados.");

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
