using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class myDoorController : MonoBehaviour
{
    private Animator doorAnim;
    [SerializeField] private UnityEvent open = null;
    [SerializeField] private string sound = null;

    private bool doorOpen = false;

    private void Awake()
    {
        doorAnim = gameObject.GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        if (!doorOpen)
        {
            doorAnim.Play(sound, 0, 0.0f);
            open.Invoke();
            doorOpen = true;

        }
        else
        {
            doorAnim.Play("DoorClose", 0 ,0);
            doorOpen = false;
        }
    }
}
