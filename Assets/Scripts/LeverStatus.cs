using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverStatus : MonoBehaviour
{
    public int leverNumber;
    
    public bool leverIsOn = false;
    private Animator switchChange;


    private void Start()
    {
        switchChange = gameObject.GetComponent<Animator>();
        leverIsOn = false;
    }

    public void PlayAnimation()
    {
        if (leverIsOn == false)
        {
            switchChange.Play("Handle_Pull");
            leverIsOn = true;
            GetLeverStatus(leverIsOn);
            
        }
        
        else
        {
            switchChange.Play("Handle_Push");
            leverIsOn = false;
            GetLeverStatus(leverIsOn);
        }
        
        
    }

    public void GetLeverStatus(bool x)
    {
        
        if (x == true)
        {
            leverIsOn = true;
        }

        else
        {
            leverIsOn = false;
        }
    }




}
