using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadSaveTest : MonoBehaviour
{
    private string nameKey = "playerName";

    public InputField myInputField;

    private void Start()
    {
        Debug.Log("El jugador se llama " + PlayerPrefs.GetString(nameKey));
    }

    public void SavePlayerName()
    {
        PlayerPrefs.SetString(nameKey, myInputField.textComponent.text);
    }

    private void Update()
    {
    }
}