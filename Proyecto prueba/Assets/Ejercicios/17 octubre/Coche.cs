using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coche 
{
    public string Marca = "Audi";
    public float precio = 30000; 


    public void Arrancar()
    {
        Debug.Log("He arrancado el coche broom broom");
    }
    public void Frenar()
    {
        Debug.Log("Esstoy frenando el coche");
    }

}
