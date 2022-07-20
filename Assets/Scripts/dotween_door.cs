using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class dotween_door : MonoBehaviour
{

    public GameObject leftdoor, rightdoor;
    private bool openDoor, closeDoor;

    // Start is called before the first frame update
    void Start()
    {
        DOTween.Init();
    }

    // Update is called once per frame
    void Update()
    {
        if (openDoor)
        {

        }
    }

    
}
