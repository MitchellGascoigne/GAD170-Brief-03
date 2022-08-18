using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitchellGascoigne
{
    public class TriggerZone : MonoBehaviour
    {
        public delegate void TriggerAction();
        public static event TriggerAction OnTrigger;
        // Detect when the sphere hits this trigger
        // Debug.log something
        // Teleport the sphere away

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Hey! A " + other.name + " has triggered this Trigger Zone!");
            //other.transform.position = new Vector3(0, 2, 0);
            if (OnTrigger != null)
            {
                OnTrigger();
            }
        }
    }
}