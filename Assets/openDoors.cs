using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoors : MonoBehaviour
{
    public float max_door_distance = 1.0f;
    private Animator anim;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));

            RaycastHit hit;
                if(Physics.Raycast(ray, out hit, 10.0f))
            {
                if(hit.collider.tag == "Door" && Vector3.Distance(Camera.main.transform.position, hit.point) < max_door_distance)
                {
                    Debug.Log("open door now");
                    anim.Play("dooropening1", 0, 0f);
                }
            }
        }
    }
    // Start is called before the first frame update

}
