using UnityEngine;
using AdventurePuzzleKit;

namespace ChessPuzzleSystem
{
    public class ChessSingleFuseController : MonoBehaviour
    {
        [Header("Type of Key")]
        [SerializeField] private ChessPieceTheme chessType = ChessPieceTheme.None;

        public enum ChessPieceTheme { None, Ruby, Weiss, Blake, Yang, Key }

        public void ChessPiecePickup()
        {
            switch (chessType)
            {
                case ChessPieceTheme.Ruby:
                    ChessInventoryManager.instance.UpdateInventory(ChessInventoryManager.InventoryPiece.Ruby);
                    break;
                case ChessPieceTheme.Weiss:
                    ChessInventoryManager.instance.UpdateInventory(ChessInventoryManager.InventoryPiece.Weiss);
                    break;
                case ChessPieceTheme.Blake:
                    ChessInventoryManager.instance.UpdateInventory(ChessInventoryManager.InventoryPiece.Blake);
                    break;
                case ChessPieceTheme.Yang:
                    ChessInventoryManager.instance.UpdateInventory(ChessInventoryManager.InventoryPiece.Yang);
                    break;
                case ChessPieceTheme.Key:
                    ChessInventoryManager.instance.UpdateInventory(ChessInventoryManager.InventoryPiece.Key);
                    break;
            }
            AKAudioManager.instance.Play("ChessPiecePickup");
            gameObject.SetActive(false);
        }
    }
}
