using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioDiaSemana : MonoBehaviour
{
    // En este ejercicio el script nos dira el dia de la semana segun el numero de dia que introduzcamos

       public int DiaSemana = 0;

                // Start is called before the first frame update
    void Start()
    {
        if (DiaSemana == 1 )
        {
            Debug.Log("El dia de la semana es lunes");
        }

        if (DiaSemana == 2)
        {
            Debug.Log("El dia de la semana es martes");
        }
        if (DiaSemana == 3)
        {
            Debug.Log("El dia de la semana es miercoles");
        }
        if (DiaSemana == 4)
        {
            Debug.Log("El dia de la semana es jueves");
        }
        if (DiaSemana == 5)
        {
            Debug.Log("El dia de la semana es viernes");
        }
        if (DiaSemana == 6)
        {
            Debug.Log("El dia de la semana es sabado");
        }
        if (DiaSemana == 7)
        {
            Debug.Log("El dia de la semana es domingo");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
