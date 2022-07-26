using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField] private GameObject winscreen;
    
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            winscreen.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0f;
        }
    }


}
