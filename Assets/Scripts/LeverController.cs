using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeverController : MonoBehaviour
{
    [Header("Add objects to Array")]
    [SerializeField] private LeverGroupController levergroup1;
    [SerializeField] private LeverGroupController levergroup2;
    [SerializeField] private LeverGroupController levergroup3;

    [SerializeField] private Animator anim;
    [SerializeField] private UnityEvent doorunlock;


    private void Update()
    {
        OpenDoor();
    }


    void OpenDoor()
    {
        if (levergroup1.correct == true && levergroup2.correct == true && levergroup3.correct == true)
        {
            doorunlock.Invoke();
        }
    }



}
