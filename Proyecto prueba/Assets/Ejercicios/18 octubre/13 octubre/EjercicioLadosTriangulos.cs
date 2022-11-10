using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioLadosTriangulos : MonoBehaviour
{
    // En este ejerciio vamos a decir que tipop de triangulo tenemos segun sus lados

    public float lado1;
    public float lado2;
    public float lado3;

    // Start is called before the first frame update
    void Start()
    {
        if ((lado1 == lado2) && (lado1 == lado3))
        {
            Debug.Log("El triangulo es equilatero");
        }
         else if ((lado1 == lado2) || (lado1 == lado3)|| (lado2 == lado3)) 
        {
            Debug.Log("El triangulo es isosceles");
        }
        else
        {
            Debug.Log("El triangulo es escaleno");
        }

       
             
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
