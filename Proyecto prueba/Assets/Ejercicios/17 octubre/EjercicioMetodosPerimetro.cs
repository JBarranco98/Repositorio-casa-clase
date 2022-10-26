using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioMetodosPerimetro : MonoBehaviour
{
    //En este ejercicio vamos a calcular el perimetro de un rectangulo dado sus lados 
    // Start is called before the first frame update
    void Start()
    {
        Coche miCoche = new Coche();

        miCoche.Arrancar();
        miCoche.Frenar();

        EjercicioClaseCirculo circulo1 = new EjercicioClaseCirculo();
        circulo1.radio = 2.1f;

      float per = circulo1.perimetro();
      float area =  circulo1.area();
      float vol = circulo1.volumen();
        Debug.Log("El perimetro del circulo es "+ per);
        Debug.Log("El area del circulo es "+ area);
        Debug.Log("El volumen de la esfera es "+ vol);

        EjercicioClaseRectangulo rectangulo1 = new EjercicioClaseRectangulo();
        rectangulo1.lado1 = 2.1f;
        rectangulo1.lado2 = 4.67f;
        rectangulo1.lado3 = 6.7f;

        float perrect = rectangulo1.perimetro();
        float arearect = rectangulo1.area();
        float volrect = rectangulo1.volumen();
        Debug.Log("El perimetro del rectangulo es " + perrect);
        Debug.Log("El area del rectangulo es " + arearect);
        Debug.Log("El volumen del rectangulo es " + volrect);




        float a = perimetro(3.4f , 5.1f);
        Debug.Log(a);
    }


    public float perimetro(float ladoA, float ladoB)
    {
        return 2 * ladoA + 2 * ladoB;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
