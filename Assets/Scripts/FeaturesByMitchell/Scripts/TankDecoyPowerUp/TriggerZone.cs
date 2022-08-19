using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitchellGascoigne
{
    public class TriggerZone : MonoBehaviour
    {
        public delegate void TriggerAction();
        public static event TriggerAction OnTriggerPlayer01;
        public static event TriggerAction OnTriggerPlayer02;
        // Detect when the "Decoy Generator" hits this trigger
        // Debug.log message


        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Hey! A " + other.name + " has triggered this Trigger Zone!");
            //other.transform.position = new Vector3(x, y, z);
            if (other.name == "Player_01(Clone)")
            {
                if (OnTriggerPlayer01 != null)
                {
                    OnTriggerPlayer01();
                }
            }
            if (other.name == "Player_02(Clone)")
            {
                if (OnTriggerPlayer02 != null)
                {
                    OnTriggerPlayer02();
                }
            }
        }
    }
}