using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apuntes : MonoBehaviour
{
    // int(numero entero) float(numero decimal) string(texto) bool (true/false)
    // + - * / %(resto)
    // == !=  <   >   <=   >=
    // Operadores logicos: && ( "esto y esto"), || (esto o esto),
    //if    (true){}        else {}     else if (false)
    // switch
    //Bucle for(){}    Tiene 3 partes: Inicializacion, hasta cuando sigue el bucle activo y actualizacion del bucle
    //Métodos  (falté el viernes y no me entero de na)
    //Clases
    //Arrays/arreglos: son tipos de objetos que se llaman colecciones.
    //Clases de unity: GameObject     GameObject.setactive(true/false);
    //transform     transform.position=new vector3(xf,yf,zf);
    //transform.position=othertransform.position;

    private int miEntero = 5;
    private int dia;

    // Start is called before the first frame update
    private void Start()
    {
        // Como sumar/restar o uno/varios numeros a nuestra variable
        miEntero = miEntero + 1;
        miEntero++;
        miEntero--;
        miEntero += 2;
        miEntero -= 2;

        //Uso del if/else if/else

        if (miEntero > 0)
        {
            Debug.Log("es positivo");
        }
        else if (miEntero < 0)
        {
            Debug.Log("es negativo");
        }
        else
        {
            Debug.Log("es cero");
        }
        //Operadores logicos
        if (miEntero > 6 && miEntero < 10)
        { }
        if (miEntero > 6 || miEntero < 10)
        { }
        if ((miEntero > 6 || miEntero < 10) && miEntero != 0)
        { }
        // Switch
        switch (miEntero)
        {
            case 1:
            case 20:
                Debug.Log("Es lunes");
                break;

            case 2:
                Debug.Log("Es martes");
                break;

            case 3:
                Debug.Log("Es miercoles");
                break;

            default:
                Debug.Log("El dia de la semana no existe");
                break;
        }
        //Bucle for
        for (miEntero = 0; miEntero < 100; miEntero++)
        {
            Debug.Log(miEntero);
        }

        // Ejemplo de array
        // public int[] num1 = { 0, 1, 3, 4, 5, 6, 7, 8, 9, 10 };

        //num1= new int[9];
        // Update is called once per frame
    }

    private void Update()
    {
    }
}