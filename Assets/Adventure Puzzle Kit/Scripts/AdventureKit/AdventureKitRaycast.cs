using UnityEngine;
using UnityEngine.UI;

namespace AdventurePuzzleKit
{
    public class AdventureKitRaycast : MonoBehaviour
    {
        [Header("Raycast Length/Layer")]
        [SerializeField] private int rayLength = 5;
        [SerializeField] private LayerMask layerMaskInteract;
        [SerializeField] private string exludeLayerName = null;
        private AKItemController raycasted_obj;
        private myDoorController door;
        private LeverStatus lever;


        private KeyCode openDoorKey = KeyCode.Mouse0;
        private KeyCode leverswap = KeyCode.Mouse0;

        [Header("UI / Crosshair")]
        [SerializeField] private Image crosshair = null;
        [HideInInspector] public bool doOnce;

        private bool isCrosshairActive;
        private const string pickupTag = "InteractiveObject";
        private const string pickupTag2 = "Door";
        private const string pickupTag3 = "Lever";


        private void Update()
        {
            Vector3 fwd = transform.TransformDirection(Vector3.forward);

            int mask = 1 << LayerMask.NameToLayer(exludeLayerName) | layerMaskInteract.value;

            if (Physics.Raycast(transform.position, fwd, out RaycastHit hit, rayLength, mask))
            {
                if (hit.collider.CompareTag(pickupTag))
                {
                    if (!doOnce)
                    {
                        raycasted_obj = hit.collider.gameObject.GetComponent<AKItemController>();
                        raycasted_obj.Highlight(true);
                        CrosshairChange(true);
                    }

                    isCrosshairActive = true;
                    doOnce = true;

                    if (Input.GetKeyDown(AKInputManager.instance.pickupKey))
                    {
                        raycasted_obj.InteractionType();

                    }
                    //added return to STOP the method from continuing if the compareTag check returns true, as we have found the tagged object we are looking for, and there is no point to continuing the method.
                    return;
                }

                if (hit.collider.CompareTag(pickupTag2))
                {
                    if (!doOnce)
                    {
                        door = hit.collider.gameObject.GetComponent<myDoorController>();
                        CrosshairChange(true);
                    }

                    isCrosshairActive = true;
                    doOnce = true;

                    if (Input.GetKeyDown(openDoorKey))
                    {
                        door.PlayAnimation();
                    }
                    //added return to STOP the method from continuing if the compareTag check returns true, as we have found the tagged object we are looking for, and there is no point to continuing the method.
                    return;
                }

                if (hit.collider.CompareTag(pickupTag3))
                {
                    if (!doOnce)
                    {
                        lever = hit.collider.gameObject.GetComponent<LeverStatus>();
                        CrosshairChange(true);
                    }

                    isCrosshairActive = true;
                    doOnce = true;

                    if (Input.GetKeyDown(leverswap))
                    {
                        lever.PlayAnimation();
                    }
                    //added return to STOP the method from continuing if the compareTag check returns true, as we have found the tagged object we are looking for, and there is no point to continuing the method.
                    return;
                }
            }

            //removed ELSE case, as it is no longer needed since all if() conditions return out of the method before reaching this point. this way, even if the raycast hits a non-tagged object, it will treat it as a non-hit and reset the cursor.
            //9 times out of 10, an if/else case can be avoided by simply returning out. This way reaching the end of the method shouldn't happen unless all previous cases fail.
            //And with that design pattern you will always be 100% certain things like resetting cursor states, etc. will run if nothing else stops the method beforehand.
            if (isCrosshairActive)
            {
                raycasted_obj.Highlight(false);
                CrosshairChange(false);
                doOnce = false;
            }

        }

        void CrosshairChange(bool on)
        {
            if (on && !doOnce)
            {
                crosshair.color = Color.red;
            }
            else
            {
                crosshair.color = Color.white;
                isCrosshairActive = false;
            }
        }
    }
}
