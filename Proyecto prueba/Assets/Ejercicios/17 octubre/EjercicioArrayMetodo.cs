using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioArrayMetodo : MonoBehaviour
{
    //En este ejercicio vamos a crear un array el cual me va a sumar cada uno de los elementos del mismo

    public int[] array;
        
        // Start is called before the first frame update
    void Start()
    {
          for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
              
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
