using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CuentaMonedas : MonoBehaviour
{
    public int currentCoins;

    public Text coins;

    public void GetCoins(int coinAmount)
    {
        if (coins != null)
        {
            coins.text = currentCoins.ToString();
        }
        else
        {
            Debug.LogError("Acuerdate de pasar el objeto en unity");
        }
        currentCoins += coinAmount;

        Debug.Log("He recogido una moneda, ya tengo " + currentCoins + " monedas.");
    }
}