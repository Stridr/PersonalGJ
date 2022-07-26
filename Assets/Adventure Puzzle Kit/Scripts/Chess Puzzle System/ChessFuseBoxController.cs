using UnityEngine;
using UnityEngine.Events;
using AdventurePuzzleKit;

namespace ChessPuzzleSystem
{
    public class ChessFuseBoxController : MonoBehaviour
    {
        [Header("Fuse Box Properties")]
        [SerializeField] private FuseBoxType _fuseBoxType = FuseBoxType.None;
        [SerializeField] private enum FuseBoxType { None, RubyFuseBox, WeissFuseBox,BlakeFuseBox, YangFuseBox, KeyFuseBox }

        [Header("Fuse placed by default?")]
        [SerializeField] private FuseType _fuseType;
        private enum FuseType { None, Ruby, Weiss, Blake, Yang, Key }
        public bool fusePlaced;

        [HideInInspector] public string fuseBoxName;
        [HideInInspector] public string fuseName;

        [Header("Fuse Objects")]
        [SerializeField] private GameObject RubyObject = null;
        [SerializeField] private GameObject WeissObject = null;
        [SerializeField] private GameObject BlakeObject = null;
        [SerializeField] private GameObject YangObject = null;
        [SerializeField] private GameObject KeyObject = null;

        [SerializeField] private UnityEvent unlock = null;

        [SerializeField] private ChessPowerManager powerManager = null;

        private ChessFuseBoxController fuseBoxController;

        private void Awake()
        {
            fuseBoxController = GetComponent<ChessFuseBoxController>();

            switch(_fuseBoxType)
            {
                case FuseBoxType.RubyFuseBox: fuseBoxName = "Ruby"; break;
                case FuseBoxType.WeissFuseBox: fuseBoxName = "Weiss"; break;
                case FuseBoxType.BlakeFuseBox: fuseBoxName = "Blake"; break;
                case FuseBoxType.YangFuseBox: fuseBoxName = "Yang"; break;
                case FuseBoxType.KeyFuseBox: fuseBoxName = "Key"; break;

            }

            if (fusePlaced)
            {
                switch (_fuseType)
                {
                    case FuseType.Ruby: _fuseType = FuseType.Ruby; fuseName = "Ruby"; ModelSwitch();  RubyObject.SetActive(true); break;
                    case FuseType.Weiss: _fuseType = FuseType.Weiss; fuseName = "Weiss"; ModelSwitch(); WeissObject.SetActive(true); break;
                    case FuseType.Blake: _fuseType = FuseType.Blake; fuseName = "Blake"; ModelSwitch(); BlakeObject.SetActive(true); break;
                    case FuseType.Yang: _fuseType = FuseType.Yang; fuseName = "Yang"; ModelSwitch(); YangObject.SetActive(true); break;
                    case FuseType.Key: _fuseType = FuseType.Key; fuseName = "Key"; ModelSwitch(); KeyObject.SetActive(true); break;

                }
            }
        }

        public void WhatType()
        {
            ChessInventoryManager.instance.invfuseBoxController = fuseBoxController;
            ChessInventoryManager.instance.OpenInventory();
        }

        private void ModelSwitch()
        {
            
            RubyObject.SetActive(false);
            WeissObject.SetActive(false);
            BlakeObject.SetActive(false);
            YangObject.SetActive(false);
            KeyObject.SetActive(false);
       
        }

        private void RemoveModel()
        {
            RubyObject.SetActive(false);
            WeissObject.SetActive(false);
            BlakeObject.SetActive(false);
            YangObject.SetActive(false);
            KeyObject.SetActive(false);


            fusePlaced = false;
            fuseName = null;

        }

        public void PlaceFuse(string fuseType)
        {
            switch (fuseType)
            {
                case "Ruby":
                    if (ChessInventoryManager.instance.hasRubyFuse && !fusePlaced)
                    {
                        _fuseType = FuseType.Ruby;
                        fuseName = "Ruby";
                        fusePlaced = true;
                        ModelSwitch();
                        RubyObject.SetActive(true);
                    }
                    break;
                case "Weiss":
                    if (ChessInventoryManager.instance.hasWeissFuse && !fusePlaced)
                    {
                        _fuseType = FuseType.Weiss;
                        fuseName = "Weiss";
                        fusePlaced = true;
                        ModelSwitch();
                        WeissObject.SetActive(true);
                    }
                    break;
                case "Blake":
                    if (ChessInventoryManager.instance.hasBlakeFuse && !fusePlaced)
                    {
                        _fuseType = FuseType.Blake;
                        fuseName = "Blake";
                        fusePlaced = true;
                        ModelSwitch();
                        BlakeObject.SetActive(true);
                    }
                    break;
                case "Yang":
                    if (ChessInventoryManager.instance.hasYangFuse && !fusePlaced)
                    {
                        _fuseType = FuseType.Yang;
                        fuseName = "Yang";
                        fusePlaced = true;
                        ModelSwitch();
                        YangObject.SetActive(true);
                    }
                    break;
                case "Key":
                    if (ChessInventoryManager.instance.hasKeyFuse && !fusePlaced)
                    {
                        _fuseType = FuseType.Key;
                        fuseName = "Key";
                        fusePlaced = true;
                        ModelSwitch();
                        KeyObject.SetActive(true);
                        unlock.Invoke();

                    }
                    break;
                case "RemoveFuse":
                        RemoveModel();
                    break;
            }
            AKAudioManager.instance.Play("ChessInsert");
            powerManager.CheckFuses();
        }
    }
}