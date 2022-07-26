using UnityEngine;
using UnityEngine.Events;

namespace ChessPuzzleSystem
{
    public class ChessPowerManager : MonoBehaviour
    {
        [SerializeField] private ChessFuseBoxController fuseBox1 = null;
        [SerializeField] private ChessFuseBoxController fuseBox2 = null;
        [SerializeField] private ChessFuseBoxController fuseBox3 = null;
        [SerializeField] private ChessFuseBoxController fuseBox4 = null;


        private bool isFuseBox1;
        private bool isFuseBox2;
        private bool isFuseBox3;
        private bool isFuseBox4;


        
        [SerializeField] private UnityEvent Unlock = null;


        public void CheckFuses()
        {
            if (fuseBox1.fuseBoxName == fuseBox1.fuseName)
                isFuseBox1 = true;
            else
                isFuseBox1 = false;

            if (fuseBox2.fuseBoxName == fuseBox2.fuseName)
                isFuseBox2 = true;
            else
                isFuseBox2 = false;

            if (fuseBox3.fuseBoxName == fuseBox3.fuseName)
                isFuseBox3 = true;
            else
                isFuseBox3 = false;

            if (fuseBox4.fuseBoxName == fuseBox4.fuseName)
                isFuseBox4 = true;
            else
                isFuseBox4 = false;


            if (isFuseBox1 && isFuseBox2 && isFuseBox3 && isFuseBox4)
            {
                Unlock.Invoke();
            }
        }
    }
}
