using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverGroupController : MonoBehaviour
{
    [SerializeField] private string leverGroupNumber = null;

    [SerializeField] private LeverStatus lever1status = null;
    [SerializeField] private LeverStatus lever2status = null;
    [SerializeField] private LeverStatus lever3status = null;
    [SerializeField] private LeverStatus lever4status = null;
    [SerializeField] private LeverStatus lever5status = null;
    [SerializeField] private LeverStatus lever6status = null;
    [SerializeField] private LeverStatus lever7status = null;
    [SerializeField] private LeverStatus lever8status = null;

 
    



    private bool lever1on = false;
    private bool lever2on = false;
    private bool lever3on = false;
    private bool lever4on = false;
    private bool lever5on = false;
    private bool lever6on = false;
    private bool lever7on = false;
    private bool lever8on = false;

    public bool correct = false;

    void Update()
    {
        CheckLevers();
        SetToCorrect();

        
    }

    

    void SetToCorrect()
    {
        if(leverGroupNumber == "1")
        {
            
            if (lever8on == true && lever7on == false && lever6on == false && lever5on == true && lever4on == false && lever3on == false && lever2on == false && lever1on == false)
            {
                correct = true;
                
                
            }
            else
            {
                correct = false;
                
            }
        }

        if (leverGroupNumber == "2")
        {
            
            if(lever8on == false && lever7on == true && lever6on == false && lever5on == true && lever4on == true && lever3on == true && lever2on == false && lever1on == false)
            {
                correct = true;
            }

            else
            {
                correct = false;
            }
        }

        if (leverGroupNumber == "3")
        {
            
            if (lever8on == false && lever7on == false && lever6on == false && lever5on == true && lever4on == true && lever3on == true && lever2on == false && lever1on == false)
            {
                correct = true;
            }
            else
            {
                correct = false;
            }
        }
    }

    void CheckLevers()
    {
        if (lever1status.leverIsOn == true)
        {
            lever1on = true;
        }

        else
        {
            lever1on = false;
        }

        if (lever2status.leverIsOn == true)
        {
            lever2on = true;
        }
        else
        {
            lever2on = false;
        }


        if (lever3status.leverIsOn == true)
        {
            lever3on = true;
        }
        else
        {
            lever3on = false;
        }


        if (lever4status.leverIsOn == true)
        {
            lever4on = true;
        }
        else
        {
            lever4on = false;
        }


        if (lever5status.leverIsOn == true)
        {
            lever5on = true;
        }
        else
        {
            lever5on = false;
        }


        if (lever6status.leverIsOn == true)
        {
            lever6on = true;
        }
        else
        {
            lever6on = false;
        }


        if (lever7status.leverIsOn == true)
        {
            lever7on = true;
        }
        else
        {
            lever7on = false;
        }


        if (lever8status.leverIsOn == true)
        {
            lever8on = true;

        }
        else
        {
            lever8on = false;
        }

    }


}
