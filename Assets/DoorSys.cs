using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSys : MonoBehaviour
{
    private Animator doorAnim;

    private void Awake()
    {
        doorAnim = gameObject.GetComponent<Animator>();
    }


}
