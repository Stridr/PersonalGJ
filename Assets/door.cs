using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{

        public Collider clickObject;
        public Animation anim;

        private Ray _ray;
        private RaycastHit _hit;
        private bool _opened;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Click();
            }
        }

        private void Click()
        {
            if (!clickObject) return;
            if (!anim) return;

            _ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(_ray, out _hit))
            {
                if (_hit.collider == clickObject)
                {
                    if (_opened)
                    {
                        anim.Play("doorClose");
                        _opened = false;
                    }
                    else
                    {
                        anim.Play("dooropening1");
                        _opened = true;
                    }

                }
            }
        }
    
}
