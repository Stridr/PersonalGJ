using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doors1 : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private ChessPuzzleSystem.ChessFuseBoxController keydoor = null;

    private Animator anim;
    [SerializeField] private string animationName = "dooropening1";

    public void CheckFuse()
    {
        if(keydoor.fusePlaced == true)
        {
            anim.Play(animationName, 0, 0.0f);
        }
    }
    

    
}
