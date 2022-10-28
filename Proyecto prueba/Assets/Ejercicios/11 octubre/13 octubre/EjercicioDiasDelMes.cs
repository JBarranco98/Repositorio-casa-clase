using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioDiasDelMes : MonoBehaviour
{
    // En este ejercicio  vamos a decir cuantos dias tiene un mes

    public string month;

    // Start is called before the first frame update
    void Start()
    {
        switch (month)
        {
            case "january":
            case "march":
            case "may":
            case "july":
            case "august":
            case "october":
            case "december":
                Debug.Log("This month has 31 days");
                break;
            case "february":
                Debug.Log("This month has 28 days");
                break;
            case "april":
            case "june":
            case "september":
            case "november":
                Debug.Log("This month has  30 days");
                break;
            default:
                Debug.Log("Enter a valid month");
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
