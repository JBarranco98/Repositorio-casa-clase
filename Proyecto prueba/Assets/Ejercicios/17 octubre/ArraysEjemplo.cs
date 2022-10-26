using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraysEjemplo : MonoBehaviour
{
    public int[] num1;
    int suma;

    // Start is called before the first frame update
    void Start()
    {
        num1 = new int[9];

        for (int i = 0; i < num1.Length; i++)
        {
            num1[i] = i;
        }
        
        for (int i = 0; i < num1.Length; i++)
        {
            suma += num1[i];
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
