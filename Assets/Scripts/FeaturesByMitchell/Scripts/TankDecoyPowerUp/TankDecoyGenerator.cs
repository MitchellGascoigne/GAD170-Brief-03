using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MitchellGascoigne
{
    public class TankDecoyGenerator : MonoBehaviour
    {
        // This function is called just after the object is enabled.
        private void OnEnable()
        {
           TriggerZone.OnTrigger += Clone;

        }
        // This function is called when the behaviour becomes disabled
        private void OnDisable()
        {
           TriggerZone.OnTrigger -= Clone;

        }
        // A clone method to clone in the "decoy" tank for each player at an assigned transform position
        private void Clone ()
        {
            transform.position = new Vector3(0, 3, 0);
        }
    }
}
