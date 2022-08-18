using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitchellGascoigne
{
    public class TankDecoyGeneratorP2 : MonoBehaviour
    {
        // This function is called just after the object is enabled.
        private void OnEnable()
        {
            TriggerZone.OnTrigger += CloneP2;

        }
        // This function is called when the behaviour becomes disabled
        private void OnDisable()
        {
            TriggerZone.OnTrigger -= CloneP2;

        }
        // A clone method to clone in the "decoy" tank at an assigned transform position
        private void CloneP2()
        {
            transform.position = new Vector3(0, 3, 0);
        }
    }
}
