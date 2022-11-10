using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioDiaSemanaConSwitch : MonoBehaviour
{ 

    //Repetiremos el ejercicio del dia de la semana segunsu numero, esta vez usando "switch"

    public int day;

    // Start is called before the first frame update
    void Start()
    {
    switch (day)
	{
           case 1:
                Debug.Log("Monday");
                break;
            case 2:
                Debug.Log("Tacotuesday");
                 break;
            case 3:
                Debug.Log("Wednesday my dudes");
                break;
            case 4:
                Debug.Log("The second tuesday");
                break;
            case 5:
                Debug.Log("It´s friday theen");
                break;
            case 6:
                Debug.Log("It´s saturday");
                break;
             case 7:
                Debug.Log("Sunday what!");
                break;
        	default:
                Debug.Log("Error");
         break;
	}
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
