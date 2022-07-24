using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionManager : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable";

    [SerializeField] private Image inven;

    void Update()
    {

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            if (selection.CompareTag("Selectable"))
            {
                inven.gameObject.SetActive(true);
            }
            
        }
    }
}
