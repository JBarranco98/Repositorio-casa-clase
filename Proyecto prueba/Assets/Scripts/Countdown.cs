using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Countdown : MonoBehaviour
{
    public float countDownTime;

    public System.Action endCountDown;

    public System.Action<int, int> actionExample;

    public System.Func<string, int> myFunctionExample;

    public UnityEvent miEventoDeunity;

    public void Method3(int entero, int entero2)
    {
    }

    //public int Method4()
    //{
    //    return 4;
    //}

    private void Start()
    {
        actionExample += Method3;
        ////actionExample += Method4;
        StartCoroutine(CountDownCorrutine());
    }

    public IEnumerator CountDownCorrutine()
    {
        yield return new WaitForSeconds(countDownTime);
        if (endCountDown != null)
        {
            endCountDown();
        }
    }
}