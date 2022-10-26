using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioAñoBisiesto : MonoBehaviour
{
    // En eset ejercicio vamos a averifuar si el año es bisisesto o no

    public int año;

    // Start is called before the first frame update
    void Start()
    {
        if ((año % 400 == 0) || (año % 4 == 0 && año % 100 !=0))
        {
            Debug.Log("El año es bisiesto");
                    }
        else
        {
            Debug.Log("El año no es bisiesto");
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
