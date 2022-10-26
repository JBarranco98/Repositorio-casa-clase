using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioClaseRectangulo 
{
    public float lado1;
    public float lado2;
    public float lado3;


    public float perimetro()
    {
        return lado1 * 2 + lado2 * 2;
    }
    public float area()
    {
        return lado1 * lado2;
    }
   public float volumen()
    {
        return lado1 * lado2 * lado3;
    }
}
