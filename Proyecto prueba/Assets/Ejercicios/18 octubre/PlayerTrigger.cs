using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    // public Transform posicionObjetivo;

    private string playertag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("algo entro en el trigger");
        if (other.gameObject.CompareTag(playertag))
        {
            //other.transform.position = posicionObjetivo.position;
            OnPlayerEnter(other.gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag(playertag))
        {
            OnPlayerStay(other.gameObject);
        }
    }

    public virtual void OnPlayerStay(GameObject playerObject)
    {
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(playertag))
        {
            OnPlayerExit(other.gameObject);
        }
    }

    public virtual void OnPlayerExit(GameObject playerObject)
    {
    }

    public virtual void OnPlayerEnter(GameObject playerObject)
    {
    }

    //private void OnTriggerExit(Collider other)
    //  {
    //    Debug.Log("algo salio del trigger");
    //    }
    //
    //  private void OnTriggerStay(Collider other)
    //{
    //  Debug.Log("algo esta dentro del trigger");
    //}
}