using UnityEngine;

namespace ExamineSystem
{
    public class InspectReveal : MonoBehaviour
    {
        [Header("Basic Reveal Elements")]
        [SerializeField] private GameObject objectToHide = null;
        [SerializeField] private GameObject objectToReveal = null;
        public Item Item;

        public void RevealHidden()
        {
            objectToHide.SetActive(false);
            objectToReveal.SetActive(true);
        }

        public void PickupExample()
        {
            
            Debug.Log("Add some additional code for when this item is collected");
            InventoryManager.Instance.Add(Item);
            Destroy(gameObject);
            objectToHide.SetActive(false);
            
            
            
        }

        private void OnMouseDown()
        {
            PickupExample();
        }
    }
}
