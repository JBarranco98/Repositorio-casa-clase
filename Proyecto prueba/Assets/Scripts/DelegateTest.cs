using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateTest : MonoBehaviour
{
    public delegate void DoSomething();

    public DoSomething something;

    //public System.Action DoAction;        // esto es lo mismo que crear un delegado pero te ahorras una linea.

    public Countdown countDown;

    public GameObject cube, ball;

    public Light streetLight;

    private void Start()
    {
        //DoAction();
        //DoAction += Method1;

        countDown.endCountDown += Method1;
        countDown.endCountDown += Method2;
        countDown.endCountDown += ChangeColor;
        countDown.endCountDown += TurnOnLight;
        countDown.endCountDown += TurnOffObject;

        //something += Method1;
        //something += Method2;
        //something();

        //something();

        //something = Method2;

        //something();
    }

    public void Method1()
    {
        Debug.Log("He lanzado el método 1.");
    }

    public void Method2()
    {
        Debug.Log("He lanzado el método 2");
    }

    public void ChangeColor()
    {
        cube.GetComponent<Renderer>().material.color = Color.red;
    }

    public void TurnOnLight()
    {
        streetLight.enabled = true;
    }

    public void TurnOffObject()
    {
        ball.SetActive(false);
    }
}