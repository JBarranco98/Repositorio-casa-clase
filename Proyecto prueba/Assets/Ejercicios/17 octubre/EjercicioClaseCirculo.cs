using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioClaseCirculo
{
    public float radio;

    public float perimetro()
    {
       return Mathf.PI * radio * 2;
    }
    public float area()
    {
        return Mathf.PI * radio * radio;
    }
    public float volumen()
    {
        return(4 * Mathf.PI * radio * radio * radio) / 3;
    }

}
