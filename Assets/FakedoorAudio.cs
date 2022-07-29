using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FakedoorAudio : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource fdoors;


    UnityEvent doorAudio;

    private void Start()
    {
        fdoors= gameObject.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            fdoors.Play();
            
        }



    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            fdoors.enabled = false;
        }
    }
}
