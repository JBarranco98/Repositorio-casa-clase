using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public int numero1 = 5;
    public int numero2 = 2;
    public int resultado;
    

    // Start is called before the first frame update
    void Start()
    {

                if (numero1 >= numero2)
        {
            Debug.Log("numero1 es mayor o igual que numero2");
         }
        else 
        {
            Debug.Log("numero1 es menor que numero2");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
