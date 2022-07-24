using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using AdventurePuzzleKit;

namespace ChessPuzzleSystem
{
    public class ChessInventoryManager : MonoBehaviour
    {
        [HideInInspector] public bool hasRubyFuse;
        [HideInInspector] public bool hasWeissFuse;
        [HideInInspector] public bool hasBlakeFuse;
        [HideInInspector] public bool hasYangFuse;
        [HideInInspector] public bool hasKeyFuse;

        [HideInInspector] public bool usingRubyBox;
        [HideInInspector] public bool usingWeissBox;
        [HideInInspector] public bool usingBlakeBox;
        [HideInInspector] public bool usingYangBox;
        [HideInInspector] public bool usingKeyBox;

        [Header("Main Key UI")]
        [SerializeField] private GameObject chessPuzzleInventoryUI;

        [Header("Key Icon UI")]
        [SerializeField] private Image RubyImageSlotUI = null;
        [SerializeField] private Image WeissImageSlotUI = null;
        [SerializeField] private Image BlakeImageSlotUI = null;
        [SerializeField] private Image YangImageSlotUI = null;
        [SerializeField] private Image KeyImageSlotUI = null;

        [Header("Type of Key")]
        private InventoryPiece _inventoryPiece;
        public enum InventoryPiece { Ruby, Weiss, Blake, Yang, Key }

        public static ChessInventoryManager instance;

        [HideInInspector] public ChessFuseBoxController invfuseBoxController;

        void Awake()
        {
            if (instance != null) { Destroy(gameObject); }
            else { instance = this; DontDestroyOnLoad(gameObject); }
        }

        public void OpenInventory()
        {
            AKUIManager.instance.OpenInventory();
        }

        public void PressButton(string buttonType)
        {
            EventSystem.current.SetSelectedGameObject(null);

            switch (buttonType)
            {
                case "Ruby":
                    if (hasRubyFuse && !invfuseBoxController.fusePlaced)
                    {
                        invfuseBoxController.PlaceFuse("Ruby");
                        hasRubyFuse = false;
                        RubyImageSlotUI.color = Color.black;
                    }
                    break;
                case "Weiss":
                    if (hasWeissFuse && !invfuseBoxController.fusePlaced)
                    {
                        invfuseBoxController.PlaceFuse("Weiss");
                        hasWeissFuse = false;
                        WeissImageSlotUI.color = Color.black;
                    }
                    break;
                case "Blake":
                    if (hasBlakeFuse && !invfuseBoxController.fusePlaced)
                    {
                        invfuseBoxController.PlaceFuse("Blake");
                        hasBlakeFuse = false;
                        BlakeImageSlotUI.color = Color.black;
                    }
                    break;
                case "Yang":
                    if (hasYangFuse && !invfuseBoxController.fusePlaced)
                    {
                        invfuseBoxController.PlaceFuse("Yang");
                        hasYangFuse = false;
                        YangImageSlotUI.color = Color.black;
                    }
                    break;
                case "Key":
                    if (hasKeyFuse && !invfuseBoxController.fusePlaced)
                    {
                        invfuseBoxController.PlaceFuse("Key");
                        hasKeyFuse = false;
                        KeyImageSlotUI.color = Color.black;
                    }
                    break;
                case "RemoveFuse":
                    if (invfuseBoxController.fusePlaced)
                    {
                        string pieceName = invfuseBoxController.fuseName;

                        switch(pieceName)
                        {
                            case "Ruby": UpdateInventory(InventoryPiece.Ruby); break;
                            case "Weiss": UpdateInventory(InventoryPiece.Weiss); break;
                            case "Blake": UpdateInventory(InventoryPiece.Blake); break;
                            case "Yang": UpdateInventory(InventoryPiece.Yang); break;
                            case "Key": UpdateInventory(InventoryPiece.Key); break;
                        }
                        
                        invfuseBoxController.PlaceFuse("RemoveFuse");
                    }
                    break;
            }
        }

        public void UpdateInventory(InventoryPiece _inventoryPiece)
        {
            switch (_inventoryPiece)
            {
                case InventoryPiece.Ruby:
                    hasRubyFuse = true;
                    RubyImageSlotUI.color = Color.white;
                    AKUIManager.instance.hasChessPiece = true;
                    break;
                case InventoryPiece.Weiss:
                    hasWeissFuse = true;
                    WeissImageSlotUI.color = Color.white;
                    AKUIManager.instance.hasChessPiece = true;
                    break;
                case InventoryPiece.Blake:
                    hasBlakeFuse = true;
                    BlakeImageSlotUI.color = Color.white;
                    AKUIManager.instance.hasChessPiece = true;
                    break;
                case InventoryPiece.Yang:
                    hasYangFuse = true;
                    YangImageSlotUI.color = Color.white;
                    AKUIManager.instance.hasChessPiece = true;
                    break;
                case InventoryPiece.Key:
                    hasKeyFuse = true;
                    KeyImageSlotUI.color = Color.white;
                    AKUIManager.instance.hasChessPiece = true;
                    break;
            }
        }
    }
}
