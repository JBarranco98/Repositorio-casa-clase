
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioArrayMedia : MonoBehaviour
{

    public int[] array;
    float suma = 0;
       
     public float MediaArray()
 {     
     for (int i = 0; i < array.Length; i++)
            {
                suma += array[i];
            }
      float media = suma / array.Length;
            return media;
 }

      private void Start()
    {
        Debug.Log(MediaArray());
    }
}
