using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitchellGascoigne
{
    public class TriggerZone : MonoBehaviour
    {
        public delegate void TriggerAction();
        public static event TriggerAction OnTrigger;
        // Detect when the "Decoy Generator" hits this trigger
        // Debug.log message
  

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Hey! A " + other.name + " has triggered this Trigger Zone!");
            //other.transform.position = new Vector3(0, 3, 0);
            if (OnTrigger != null)
            {
                OnTrigger();
            }
        }
    }
}