using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int MaxHealth;
    private int currentHealth;

    private Vector3 InitialPosition;

    public Text healthText;

    private void Start()
    {
        InitialPosition = transform.position;
        currentHealth = MaxHealth;
        healthText.text = currentHealth.ToString();
    }

    public void TakeDamage(int damageTaken)
    {
        currentHealth -= damageTaken;
        healthText.text = currentHealth.ToString();

        if (currentHealth <= 0)
        {
            Debug.Log("Estoy muerto");
            transform.position = InitialPosition;
            currentHealth = MaxHealth;
            healthText.text = currentHealth.ToString();
        }
        else
        {
            Debug.Log("He recibido da�o, me quedan " + currentHealth + " puntos de vida.");
        }
    }
}