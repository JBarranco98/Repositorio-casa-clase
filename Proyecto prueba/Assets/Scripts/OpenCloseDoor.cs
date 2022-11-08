using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseDoor : MonoBehaviour
{
    public Animator DoorAnimator;
    private bool doorIsOpen = true;

    public void OpenClose()
    {
        DoorAnimator.SetBool("OpenDoor", doorIsOpen);
        doorIsOpen = !doorIsOpen;
    }
}