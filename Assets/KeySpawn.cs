using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawn : MonoBehaviour
{
    // Start is called before the first frame update
    
    
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            
            int mylayer = LayerMask.NameToLayer("Interact");
            gameObject.layer = mylayer;
            gameObject.tag = "InteractiveObject";
            Debug.Log("Layer and tag changed");
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
